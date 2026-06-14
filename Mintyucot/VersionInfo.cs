using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Mintyucot
{
    internal class VersionInfo
    {
        private static readonly string _appPath = PathInfo.AssemblyFilePath;

        public static string? AppName => FileVersionInfo.GetVersionInfo(_appPath).ProductName;

        public static string? AppVersion => FileVersionInfo.GetVersionInfo(_appPath).ProductVersion;

        public static string? Developer => FileVersionInfo.GetVersionInfo(_appPath).CompanyName;

        public static string? Copyright => FileVersionInfo.GetVersionInfo(_appPath).LegalCopyright;

        public static string OSVersion => Environment.OSVersion.ToString();

        public static string DotNetVersion => RuntimeInformation.FrameworkDescription;

        public static string SystemArchitecture => RuntimeInformation.OSArchitecture.ToString();

        public static string AppArchitecture => RuntimeInformation.ProcessArchitecture.ToString();
    }
}
