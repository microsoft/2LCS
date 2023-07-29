using LCS.Forms;
using LCS.JsonObjects;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LCS
{
    public class URIHandler
    {
        public const string URI_PROTOCOL_NAME = "MS-2LCS";

        public static string LCS_DIAG_URL = Properties.Settings.Default.lcsDiagURL;
        public static string LCS_UPDATE_URL = Properties.Settings.Default.lcsUpdateURL;
        public static string LCS_URL = Properties.Settings.Default.lcsURL;
        public static string LCS_FIX_URL = Properties.Settings.Default.lcsFixURL;

        public static bool DetectURILaunch(string[] args)
        {
            bool retVal = false;

            foreach (string arg in args)
            {
                if (Uri.TryCreate(arg, UriKind.RelativeOrAbsolute, out Uri srcUri))
                {
                    Uri  uri = srcUri.IsAbsoluteUri ?  srcUri : new Uri(new Uri("ms-2lcs://lcs.dynamics.com/"), arg);
                    retVal = retVal || uri.Scheme == URI_PROTOCOL_NAME.ToLower();
                    if (retVal) break;
                }
            }

            return retVal;
        }

        public static bool RemoveHandler()
        {
            bool retVal = false;
            if (IsAdministratorAccessProvided())
            { 
                Registry.ClassesRoot.DeleteSubKeyTree(URI_PROTOCOL_NAME, false);            
                
                MessageBox.Show($"{URI_PROTOCOL_NAME} protocol handler registration removed.");
                retVal = true;
            }
            return retVal;
        }

        public static bool RegisterHandler()
        {
            bool retVal = true;

            retVal = retVal && IsAdministratorAccessProvided();
            retVal = retVal && RemoveHandler();

            if (retVal)
            { 
                RegistryKey rootKey = Registry.ClassesRoot.CreateSubKey(URI_PROTOCOL_NAME.ToLower());

                if (rootKey  != null)
                {
                    string appAssemblyLocation = Assembly.GetExecutingAssembly().Location;

                    rootKey.SetValue("", $"URL:{URI_PROTOCOL_NAME.ToLower()}");
                    rootKey.SetValue("URL Protocol", "");

                    rootKey.CreateSubKey("DefaultIcon")
                           .SetValue("", appAssemblyLocation);

                    rootKey.CreateSubKey("shell")
                           .CreateSubKey("open")
                           .CreateSubKey("command")
                           .SetValue("", $@"""{appAssemblyLocation}"" ""%1""");
                }

                MessageBox.Show($"{URI_PROTOCOL_NAME} protocol  handler registration completed.\nRemember to not move the executable to other location or re-register it after.");
                retVal = true;
            }
            return  retVal;
        }

        private static bool IsAdministratorAccessProvided()
        {
             bool isAdmin = CheckIsUserAdministrator();

            if (!isAdmin)
            {
                MessageBox.Show("You must be system administrator", "Insufficient privilidges", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isAdmin;
        }

        private static bool CheckIsUserAdministrator() => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
    }
}
