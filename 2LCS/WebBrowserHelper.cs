//Use latest version of Internet Explorer in the webbrowser control
//https://stackoverflow.com/questions/17922308/use-latest-version-of-internet-explorer-in-the-webbrowser-control
using System;

namespace LCS
{
    public static class WebBrowserHelper
    {
        public static void FixBrowserVersion()
        {
            var appName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().Location);
            FixBrowserVersion(appName);
        }

        public static void FixBrowserVersion(string appName)
        {
            FixBrowserVersion(appName, GetEmbVersion());
        }

        // FixBrowserVersion("<YourAppName>", 9000);
        public static void FixBrowserVersion(string appName, int ieVer)
        {
            FixBrowserVersion_Internal("HKEY_LOCAL_MACHINE", appName + ".exe", ieVer);
            FixBrowserVersion_Internal("HKEY_CURRENT_USER", appName + ".exe", ieVer);
            FixBrowserVersion_Internal("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", ieVer);
            FixBrowserVersion_Internal("HKEY_CURRENT_USER", appName + ".vshost.exe", ieVer);
        }

        public static int GetEmbVersion()
        {
            var ieVer = GetBrowserVersion();

            if (ieVer > 9)
                return ieVer * 1000 + 1;

            if (ieVer > 7)
                return ieVer * 1111;

            return 7000;
        } // End Function GetEmbVersion

        // End Sub FixBrowserVersion

        // End Sub FixBrowserVersion

        private static void FixBrowserVersion_Internal(string root, string appName, int ieVer)
        {
            try
            {
                //For 64 bit Machine
                if (Environment.Is64BitOperatingSystem)
                    Microsoft.Win32.Registry.SetValue(root + @"\Software\Wow6432Node\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, ieVer);
                //For both 32 bit and 64 bit Machine
                Microsoft.Win32.Registry.SetValue(root + @"\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, ieVer);
            }
            catch (Exception)
            {
                // some config will hit access rights exceptions
                // this is why we try with both LOCAL_MACHINE and CURRENT_USER
            }
        } // End Sub FixBrowserVersion_Internal

        private static int GetBrowserVersion()
        {
            // string strKeyPath = @"HKLM\SOFTWARE\Microsoft\Internet Explorer";
            const string strKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer";
            var ls = new[] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };

            var maxVer = 0;
            foreach (var t in ls)
            {
                var objVal = Microsoft.Win32.Registry.GetValue(strKeyPath, t, "0");
                var strVal = Convert.ToString(objVal);
                var iPos = strVal.IndexOf('.');
                if (iPos > 0)
                    strVal = strVal.Substring(0, iPos);

                if (int.TryParse(strVal, out var res))
                    maxVer = Math.Max(maxVer, res);
            }

            return maxVer;
        } // End Function GetBrowserVersion
    }
}