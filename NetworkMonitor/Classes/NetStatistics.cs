using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkMonitor.Properties;

namespace NetworkMonitor.Classes
{
    class NetStatistics
    {
        #region Private Members

        private NetInfo _netInfo;
        private bool _isComputed;
        private Dictionary<StatisticEnum, string> _dicStats = new Dictionary<StatisticEnum, string>();

        #endregion


        public enum StatisticEnum
        {
            StatAll = 0,
            StatCountIn = 1,
            StatAvgHour = 2
        }
        
        public NetStatistics(NetInfo netInfo)
        {
            _netInfo = netInfo;
            netInfo.MonitoringStarted += NetInfoOnMonitoringStarted;
            netInfo.MonitoringStopped += NetInfoOnMonitoringStopped;
            netInfo.Disconnected += NetInfoOnDisconnected;
        }

        private void NetInfoOnMonitoringStopped(object sender, EventArgs eventArgs)
        {
            StopTime = DateTime.Now;
        }

        private void NetInfoOnDisconnected(object sender, EventArgs eventArgs)
        {
            DisconnectionsCount++;
        }

        private void NetInfoOnMonitoringStarted(object sender, EventArgs eventArgs)
        {
            ResetCounters();
        }

        private void ResetCounters()
        {
            DisconnectionsCount = 0;
            StartTime = DateTime.Now;
            _isComputed = false;
        }
        

        #region Get Statistics Methods

        /// <summary>
        /// Return the string format from Resource according to requested statistics
        /// </summary>
        /// <param name="stat_enum"></param>
        /// <returns></returns>
        private string GetStatStringFormat(StatisticEnum stat_enum)
        {
            return Resources.ResourceManager.GetString($"STAT_{stat_enum}");
        }

        //public static string ToReadableString(this TimeSpan ts)
        //{
        //    string str = "", sAnd = "";
        //    if (ts.TotalHours > 0)
        //    {
        //        str = $"{ts.TotalHours}h";
        //        sAnd = " and ";
        //    }
        //    if (ts.TotalMinutes > 0)
        //    {
        //        str = $"{str}{sAnd}{ts.TotalMinutes}";
        //    }
        //    if (sAnd == "" && ts.TotalMinutes)

        //    return str;
        //}

        public static string TimeSpanAsString(TimeSpan span)
        {
            string formatted = string.Format("{0}{1}{2}{3}",
                span.Duration().Days > 0 ? string.Format("{0:0} day{1}, ", span.Days, span.Days == 1 ? String.Empty : "s") : string.Empty,
                span.Duration().Hours > 0 ? string.Format("{0:0} hour{1}, ", span.Hours, span.Hours == 1 ? String.Empty : "s") : string.Empty,
                span.Duration().Minutes > 0 ? string.Format("{0:0} minute{1}, ", span.Minutes, span.Minutes == 1 ? String.Empty : "s") : string.Empty,
                span.Duration().Seconds > 0 ? string.Format("{0:0} second{1}", span.Seconds, span.Seconds == 1 ? String.Empty : "s") : string.Empty);

            if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

            if (string.IsNullOrEmpty(formatted)) formatted = "0 seconds";

            return formatted;
        }

        private void Compute(StatisticEnum stat_enum, bool force=false)
        {
            if (!_isComputed || force)
            {

                DateTime dtComputeEnd = _netInfo.IsMonitoring ? DateTime.Now : StopTime;
                string sSpan = TimeSpanAsString(dtComputeEnd.Subtract(StartTime));

                // Return number of disconnections in elapsed time
                if (stat_enum == StatisticEnum.StatAll || stat_enum == StatisticEnum.StatCountIn)
                {
                    _dicStats[StatisticEnum.StatCountIn] = string.Format(GetStatStringFormat(StatisticEnum.StatCountIn),
                        DisconnectionsCount, sSpan);
                }

                if (stat_enum == StatisticEnum.StatAll || stat_enum == StatisticEnum.StatAvgHour)
                {
                    //_dicStats[StatisticEnum.StatAvgHour] = string.Format(
                    //  GetStatStringFormat(StatisticEnum.StatAvgHour), "[TODO]");
                }

                if (stat_enum == StatisticEnum.StatAll)
                {
                    // only if we computed all and not monitoring anymore, we set _isComputed = true
                    if (!_netInfo.IsMonitoring) _isComputed = true;
                }
            }
        }

        public List<string> GetAll()
        {
            Compute(StatisticEnum.StatAll);
            return _dicStats.Values.ToList();
        }

        public string Get(StatisticEnum stat_enum, string seperator="\n")
        {

            Compute(stat_enum);

            if (stat_enum == StatisticEnum.StatAll)
            {
                // return all statistics
                return string.Join(seperator, _dicStats.Values);
            }

            // return requested statistics
            return _dicStats[stat_enum];
        }

        #endregion


        #region Public Properties

        public int DisconnectionsCount { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }

        #endregion
    }
}
