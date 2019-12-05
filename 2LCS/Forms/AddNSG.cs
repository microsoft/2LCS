using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class AddNsg : Form
    {
        private const int CpNocloseButton = 0x200;

        public AddNsg()
        {
            InitializeComponent();
        }

        public bool Cancelled { get; private set; }
        public Dictionary<string, string> Rule { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CpNocloseButton;
                return myCp;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!ValidateRule())
            {
                Cancelled = true;
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private bool ValidateRule()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Rule name is empty.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("IP address field is empty.");
                return false;
            }
            Rule = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { textBox1.Text, textBox2.Text}
            };
            return true;
        }
    }
}