using System;
using System.IO;
using System.Reflection;

namespace NetworkMonitor.Helpers
{
    internal static class AppInfo
    {
        public static string AppPath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            }
        }

        public static string AppExeFullPath
        {
            get
            {
                return Assembly.GetEntryAssembly().Location;
            }
        }

        public static string AppName
        {
            get
            {
                return ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title;
                //Assembly.GetEntryAssembly().GetName().FullName;
            }
        }

        public static Version AppVersion
        {
            get
            {
                return Assembly.GetEntryAssembly().GetName().Version;
            }
        }

        public static string AppVersionString
        {
            get
            {
                return Assembly.GetEntryAssembly().GetName().Version.ToString(3);
            }
        }

        public static string AppVersionFull(string format = "{0} (revision {1})")
        {
            return string.Format(format, Assembly.GetEntryAssembly().GetName().Version.ToString(3), AppRevisionNumber);
        }

        public static int AppBuildNumber
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.Build; }
        }

        public static int AppRevisionNumber
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.Revision; }
        }

        public static string AppDescription
        {
            get
            {
                return ((AssemblyDescriptionAttribute)Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0]).Description;
            }
        }

        public static string AppAuthor
        {
            get
            {
                return "Tal Bener";
            }
        }

        public static string AppCopyright
        {
            get
            {
                return ((AssemblyCopyrightAttribute)Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright;
            }
        }
    }
}
