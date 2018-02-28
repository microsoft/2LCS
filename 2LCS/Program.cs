using LCS.Forms;
using System;
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
    }
}
