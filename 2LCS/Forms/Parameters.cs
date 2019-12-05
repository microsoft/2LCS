using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Parameters : Form
    {
        private const int CpNocloseButton = 0x200;

        public Parameters()
        {
            InitializeComponent();
        }

        public bool Autorefresh { get; private set; }
        public bool Cancelled { get; private set; }

        private void AutoRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autorefresh = AutoRefreshCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            AutoRefreshCheckBox.Checked = Properties.Settings.Default.autorefresh;
        }
    }
}