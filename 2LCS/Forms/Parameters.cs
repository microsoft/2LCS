using System;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
        }

        public bool Autorefresh { get; private set; }
        public bool Cancelled { get; private set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            setParameters();
            Close();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            AutoRefreshCheckBox.Checked = Properties.Settings.Default.autorefresh;
            textBoxProjectExcl.Text = Properties.Settings.Default.projOrgExcl;
        }

        private void setParameters()
        {
            Properties.Settings.Default.autorefresh = AutoRefreshCheckBox.Checked;
            Properties.Settings.Default.projOrgExcl = textBoxProjectExcl.Text;
            Properties.Settings.Default.Save();
        }
    }
}