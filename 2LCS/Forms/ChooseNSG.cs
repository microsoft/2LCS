using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChooseNSG : Form
    {
        internal bool Cancelled { get; private set; }
        public NetworkSecurityGroup NetworkSecurityGroup;
        public NSGRule NSGRule;
        private bool _sortAscending;
        readonly BindingSource _nsgRulesSource = new BindingSource();

        private const int CpNocloseButton = 0x200;

        public ChooseNSG()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (nsgRulesDataGridView.SelectedRows.Count > 0)
            {
                NSGRule = (NSGRule)nsgRulesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
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

        private void ChoosePackage_Load(object sender, EventArgs e)
        { 
            nsgRulesDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = nsgRulesDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(nsgRulesDataGridView, true, null);
            }
            nsgRulesDataGridView.DataSource = _nsgRulesSource;
            if(NetworkSecurityGroup != null)
            {
                _nsgRulesSource.DataSource = NetworkSecurityGroup.Rules.OrderBy(f => f.Name);
            }
        }

        private void PackagesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (nsgRulesDataGridView.DataSource == null) return;
            _nsgRulesSource.DataSource = _sortAscending ? NetworkSecurityGroup.Rules.OrderBy(nsgRulesDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : NetworkSecurityGroup.Rules.OrderBy(nsgRulesDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }

        private void PackagesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (nsgRulesDataGridView.SelectedRows.Count > 0)
            {
                NSGRule = (NSGRule)nsgRulesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }
    }
}
