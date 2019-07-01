using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Parameters : Form
    {
        public bool Cancelled { get; private set; }
        public bool Autorefresh { get; private set; }
        private const int CpNocloseButton = 0x200;
        public Parameters()
        {
            InitializeComponent();
        }

        private void AutoRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autorefresh = AutoRefreshCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            AutoRefreshCheckBox.Checked = Properties.Settings.Default.autorefresh;
        }
    }
}
