using LCS.Forms;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace LCS
{
    internal static class Program
    {
        static MainForm mainForm;

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Please login to LCS again. Your cookie probably expired.");
            GetMainFormAndCloseOthers();
            mainForm.Cursor = Cursors.Default;
            mainForm.SetLoginButtonEnabled();
            mainForm.LoginToLCSMenuItem_Click(null, null);
        }

        private static void GetMainFormAndCloseOthers()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm locMainForm)
                {
                    mainForm = locMainForm;
                }
                else
                {
                    form.Hide();
                    form.Close();
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            
            // Copy user settings from previous application version if necessary
            if (Properties.Settings.Default.update)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.update = false;
                Properties.Settings.Default.Save();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (URIHandler.DetectURILaunch(Environment.GetCommandLineArgs()))
            {
                Application.Run(new RDPConnect());
            }  else
            { 
                Application.Run(new MainForm());
            }
        }
    }
}