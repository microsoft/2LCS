using LCS.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            Application.Run(new MainForm());
        }

        static MainForm GetMainForm()
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainForm)
                    return (MainForm)form;
            return null;
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            switch (e.Exception.Source)
            {
                case "System.Net.Http" when e.Exception.Message == $"Response status code does not indicate success: 498 ().":
                    MessageBox.Show("Please login to LCS again. Your cookie is probably invalid or expired.");
                    var mainForm = GetMainForm();
                    mainForm.Cursor = Cursors.Default;
                    mainForm.SetLoginButtonEnabled();
                    break;
                default:
                    throw e.Exception;
            }
        }
    }
}

