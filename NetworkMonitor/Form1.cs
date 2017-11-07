using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Timer = System.Timers.Timer;
using System.Threading;
using NetworkMonitor.Classes;
using NetworkMonitor.Helpers;
using NetworkMonitor.Properties;

namespace NetworkMonitor
{
    public partial class Form1 : Form
    {
        private Color _connectedColor;
        private Icon _connectedIcon;
        private bool _showInfo;
        private readonly Dictionary<NetLog, DataGridViewRow> _logToGridRows = new Dictionary<NetLog, DataGridViewRow>();

        private NetInfo _netInfo;

        private int _countDisconnections;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddLog(NetLog netLog)
        {
            int i =  gridLog.Rows.Add(netLog.TimeAsString(), netLog.LogMessage);
            _logToGridRows[netLog] = gridLog.Rows[i];
            gridLog.ClearSelection();
            
        }

        private void FillLog()
        {
            _logToGridRows.Clear();
            gridLog.Rows.Clear();
            foreach (NetLog netLog in NetLog.LogList)
            {
                AddLog(netLog);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NetLog.LogAdded += (o, args) => { AddLog((NetLog) o); };
            NetLog.LogChanged += (o, args) =>
            {
                NetLog log = o as NetLog;
                if (log != null)
                {
                    if (_logToGridRows.ContainsKey(log))
                        _logToGridRows[log].Cells[1].Value = log.LogMessage;
                }
                else
                {
                    FillLog();
                }
            };

            
            

            _netInfo = new NetInfo();
            _netInfo.MonitoringStarted += NetInfoOnMonitoringStarted;
            _netInfo.MonitoringStopped += NetInfoOnMonitoringStopped;
            _netInfo.Disconnected += NetInfoOnDisconnected;
            _netInfo.Connected += NetInfoOnConnected;
            SetMonitoring(true);

            // Info panel
            ShowInfo(_showInfo);

            lblSoftwareInfo.Text = $"Version {AppInfo.AppVersionString}\n\n{AppInfo.AppCopyright}";
            lblDescription.Text = AppInfo.AppDescription;
            
        }

        private void NetInfoOnConnected(object sender, EventArgs eventArgs)
        {
            UpdateUI(true);
        }

        private void NetInfoOnDisconnected(object sender, EventArgs e)
        {
            _connectedColor = Color.Yellow;
            _connectedIcon = Resources.Warning;
            UpdateUI(false);
        }

        private void ResetVars()
        {
            _connectedColor = Color.Green;
            _connectedIcon = Resources.Connected;
        }

        private void NetInfoOnMonitoringStopped(object sender, EventArgs eventArgs)
        {
            ResetVars();
        }

        private void NetInfoOnMonitoringStarted(object sender, EventArgs eventArgs)
        {
            ResetVars();
        }

        
        

        // for adding custom message to the log
        private void AddLog(string s)
        {
            NetLog.Add(s);
        }

        private void UpdateUI()
        {
            UpdateUI(_netInfo.IsConnected(), "Netword check: {0}");
        }

        private void UpdateUI(bool connected, string log="")
        {
            string str_con = connected ? Resources.STR_CONNECTED : Resources.STR_DISCONNECTED;
            tbStartMonitor.Text = $"{(_netInfo.IsMonitoring ? "Stop" : "Start")} Monitoring";
            lblConnection.BackColor = _netInfo.IsMonitoring ? (connected ? _connectedColor : Color.Red) : Color.White;
            lblConnection.Text = $"Network {str_con}";
            if (!_netInfo.IsMonitoring) lblConnection.Text += " (Not Monitoring)";
            Icon = connected || !_netInfo.IsMonitoring ? _connectedIcon : Resources.Disconnected;
            Text = $"{AppInfo.AppName}";
            if (_netInfo.IsMonitoring) Text += $" - {str_con}";
            if (log != "") AddLog(string.Format(log, str_con));
        }

        private void SetMonitoring(bool monitor)
        {
            if (monitor)
            {
                if (chkClearLog.Checked) NetLog.Clear();
                _netInfo.StartMonitor();
            }
            else
                _netInfo.StopMonitor();

            UpdateUI(_netInfo.IsConnected());
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _netInfo.StopMonitor();

        }
        
        void ShowInfo(bool show)
        {
            _showInfo = show;
            pnlMain.Panel2Collapsed = !_showInfo;
        }

        private void btnToggleInfo_Click(object sender, EventArgs e)
        {
            ShowInfo(!_showInfo);
        }
        
        private void tbStartMonitor_Click(object sender, EventArgs e)
        {
            // toggle monitoring
            SetMonitoring(!_netInfo.IsMonitoring);
        }

        private void tbClearLog_Click(object sender, EventArgs e)
        {
            NetLog.Clear();
            if (_netInfo.IsMonitoring) AddLog("Monitoring...");
        }

        private void tbCheckNetwork_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            //string email = ((Label) sender).Text;
            //System.Diagnostics.Process.Start($"mailto:{email}");
        }

        private void tbCopyEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEmail.Text);
        }

        private void tbEmail_ButtonClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"mailto:{tbEmail.Text}");
        }

        private void tbLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/tbener/");
        }

        private void tbLinks_MouseEnter(object sender, EventArgs e)
        {
            toolStrip.Cursor = Cursors.Hand;
        }

        private void tbLinks_MouseLeave(object sender, EventArgs e)
        {
            toolStrip.Cursor = Cursors.Default;
        }

        private void tbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tbener");
        }
    }
}
