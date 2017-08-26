using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitor.Classes
{
    public delegate void MonitoringStartEventHandler();

    class NetInfo : IDisposable
    {

        #region Public Members

        public event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged;
        public event EventHandler MonitoringStarted;
        public event EventHandler MonitoringStopped;
        public event EventHandler Connected;
        public event EventHandler Disconnected;

        #endregion

        #region Private Members

        private readonly BackgroundWorker _backgroundWorker;
        private NetworkAvailabilityEventArgs _e;

        #endregion

        #region CTOR

        public NetInfo()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            Statistics = new NetStatistics(this);
            NetLog.Init(this);

        }

        #endregion

        #region Public Methods

        public void StartMonitor()
        {
            if (RegisterEventSafe(true))
            {
                MonitoringStarted?.Invoke(this, EventArgs.Empty);
            }
        }

        public void StopMonitor()
        {
            if (RegisterEventSafe(false))
            {
                MonitoringStopped?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool IsConnected()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        #endregion
        
        #region Private Methods
        

        private bool RegisterEventSafe(bool register)
        {
            bool changed = false;
            if (register)
            {
                if (!IsMonitoring)
                {
                    NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
                    changed = true;
                }
            }
            else
            {
                if (IsMonitoring)
                {
                    NetworkChange.NetworkAvailabilityChanged -= NetworkChange_NetworkAvailabilityChanged;
                    changed = true;
                }
            }
            IsMonitoring = register;
            return changed;
        }

        #endregion

        #region Event Handlers

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NetworkAvailabilityChanged?.Invoke(sender, _e);
            if (_e.IsAvailable)
                Connected?.Invoke(this, EventArgs.Empty);
            else
                Disconnected?.Invoke(this, EventArgs.Empty);
        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            _e = e;
            _backgroundWorker.RunWorkerAsync();
        }

        #endregion

        #region Public Properties

        public static bool IsWifi { get; set; }

        public bool IsMonitoring { get; private set; }

        public NetStatistics Statistics { get; private set; }


        #endregion

        #region IDisposable

        public void Dispose()
        {
            RegisterEventSafe(false);
        }

        #endregion

        
    }
}
