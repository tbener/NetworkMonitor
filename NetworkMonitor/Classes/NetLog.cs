using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitor.Classes
{
    class NetLog
    {
        #region EventHandlers
        public static event EventHandler LogAdded;
        public static event EventHandler LogChanged;
        #endregion

        #region Log strings

        public static string MSG_STARTEDMONITORING = "Monitoring Started.";
        public static string MSG_STOPPEDMONITORING = "Monitoring Stopped.";
        public static string MSG_CONNECTED = "Connected.";
        public static string MSG_DISCONNECTED = "Disonnected.";
        public static string MSG_RECONNECTED = "Disonnected. Reconnected after {0} seconds";

        #endregion

        #region Members

        private static NetInfo _netInfo;
        private static string TIME_DISPLAY_FORMAT = "d/M/yy HH:mm";

        private static TimeSpan RECONNECT_MAX_TIME = new TimeSpan(0,1,0);

        private static NetLog _lastDisconnect = null;

        #endregion

        #region CTOR and initializations

        private NetLog(string msg)
        {
            LogTime = DateTime.Now;
            LogMessage = msg;
        }

        static NetLog()
        {
            LogList = new List<NetLog>();
        }

        public static void Init(NetInfo netInfo)
        {
            _netInfo = netInfo;
            netInfo.Connected += NetInfo_Connected;
            netInfo.Disconnected += NetInfo_Disconnected;
            netInfo.MonitoringStarted += NetInfoOnMonitoringStarted;
            netInfo.MonitoringStopped += NetInfoOnMonitoringStopped;
        }



        #endregion

        #region NetInfo EVENTS

        private static void NetInfoOnMonitoringStopped(object sender, EventArgs args)
        {
            Add(MSG_STOPPEDMONITORING);
            Add("Summary:");
            foreach (string stat in _netInfo.Statistics.GetAll())
            {
                Add($"     {stat}");
            }
        }

        private static void NetInfoOnMonitoringStarted(object sender, EventArgs args)
        {
            Add(MSG_STARTEDMONITORING);
        }

        private static void NetInfo_Disconnected(object sender, EventArgs e)
        {
            _lastDisconnect = new NetLog(MSG_DISCONNECTED);
            Add(_lastDisconnect);
        }

        private static void NetInfo_Connected(object sender, EventArgs e)
        {
            if (_lastDisconnect != null && DateTime.Now.Subtract(_lastDisconnect.LogTime) < RECONNECT_MAX_TIME)
            {
                _lastDisconnect.Update(string.Format(MSG_RECONNECTED,
                    Math.Round(DateTime.Now.Subtract(_lastDisconnect.LogTime).TotalSeconds)));
            }
            else
                Add(MSG_CONNECTED);

            _lastDisconnect = null;
        }

        #endregion

        #region Logging

        private static void Add(NetLog netLog)
        {
            LogList.Add(netLog);
            LogAdded?.Invoke(netLog, EventArgs.Empty);
        }
        public static void Add(string msg)
        {
            Add(new NetLog(msg));
        }

        private void Update(string msg)
        {
            LogMessage = msg;
            LogChanged?.Invoke(this, EventArgs.Empty);
        }

        public static void Clear()
        {
            LogList.Clear();
            _lastDisconnect = null;
            LogChanged?.Invoke(null, EventArgs.Empty);
        }

        #endregion

        #region Public Methods

        public string TimeAsString()
        {
            return LogTime.ToString(TIME_DISPLAY_FORMAT);
        }

        #endregion

        #region Public Properties

        public string LogMessage { get; private set; }

        public DateTime LogTime { get; set; }


        public static List<NetLog> LogList { get; }

        #endregion
    }
}
