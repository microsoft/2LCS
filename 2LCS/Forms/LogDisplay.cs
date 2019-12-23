using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class LogDisplay : Form
    {
        public LogDisplay()
        {
            InitializeComponent();
        }

        public string LogEntries { get; set; }

        private void LogDisplay_Load(object sender, EventArgs e)
        {
            logTextBox.Text = LogEntries;
            logTextBox.Select(0, 0);
        }
    }
}