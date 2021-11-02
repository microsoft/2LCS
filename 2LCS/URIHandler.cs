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

        public const string LCS_DIAG_URL = "https://diag.lcs.dynamics.com";
        public const string LCS_UPDATE_URL = "https://update.lcs.dynamics.com";
        public const string LCS_URL = "https://lcs.dynamics.com";

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

        public static bool Uninstall()
        {
            if (!RequireAdministratorPrivilages()) return false;

            Registry.ClassesRoot.DeleteSubKeyTree(URI_PROTOCOL_NAME, false);

            MessageBox.Show("RDP Protocol Handler uninstalled.");

            return true;
        }

        public static bool Install()
        {
            bool retVal = true;

            if (!RequireAdministratorPrivilages()) return false;

            retVal = retVal && Uninstall();
            if (retVal)
            { 
                Assembly assembly = Assembly.GetExecutingAssembly();
                string handlerLocation = assembly.Location;

                //-- create registy structure
                RegistryKey rootKey = Registry.ClassesRoot.CreateSubKey(URI_PROTOCOL_NAME.ToLower());

                if (rootKey  != null)
                {
                    RegistryKey defaultIconKey = rootKey.CreateSubKey("DefaultIcon");
                    RegistryKey commandKey = rootKey.CreateSubKey("shell")?.CreateSubKey("open")?.CreateSubKey("command");

                    rootKey.SetValue("", $"URL:{URI_PROTOCOL_NAME.ToLower()}");
                    rootKey.SetValue("URL Protocol", "");

                    defaultIconKey?.SetValue("", handlerLocation);
                    commandKey?.SetValue("", $@"""{handlerLocation}"" ""%1""");
                }

                MessageBox.Show($"RDP Protocol Handler installed\nWARNING: Do not move this '{assembly.FullName}' to other location, otherwise handler will not work. If you change the location run installation process again.");

                retVal = true;
            }
            return  retVal;
        }

        private static bool RequireAdministratorPrivilages()
        {
            var isAdmin = IsUserAdministrator();

            if (!isAdmin)
            {
                MessageBox.Show("You must be system administrator", "Insufficient privilidges", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isAdmin;
        }

        private static bool IsUserAdministrator()
        {
            using WindowsIdentity user = WindowsIdentity.GetCurrent();
            try
            {
                //get the currently logged in user
                WindowsPrincipal principal = new WindowsPrincipal(user);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
    }
}
