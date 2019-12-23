using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChooseService : Form
    {
        public List<ServiceToRestart> AvailableServices;
        public List<ServiceToRestart> ServicesToRestart;
        private const int CpNocloseButton = 0x200;

        public ChooseService()
        {
            InitializeComponent();
        }

        internal bool Cancelled { get; private set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void ChooseService_Load(object sender, EventArgs e)
        {
            ServicesToRestart = new List<ServiceToRestart>();
            RadioButton box;
            var i = 1;
            foreach(var service in AvailableServices)
            {
                box = new RadioButton
                {
                    Tag = i.ToString(),
                    Text = service.Label,
                    Name = service.Value,
                    AutoSize = true,
                    Location = new Point(20, i * 20)
                };
                Controls.Add(box);
                i++;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in Controls.OfType<CheckBox>().Where(c=>c.Checked))
            {
                ServicesToRestart.Add(new ServiceToRestart { Label = checkBox.Text, Value = checkBox.Name });
            }


            if (ServicesToRestart.Count == 0)
            {
                Cancelled = true;
            }
            Close();
        }
    }
}