using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class LogDisplay : Form
    {
        public string LogEntries { get; set; }
        public LogDisplay()
        {
            InitializeComponent();
        }

        private void PowerShell_Load(object sender, EventArgs e)
        {
            logTextBox.Text = LogEntries;
            logTextBox.Select(0, 0);
        }
    }
}
