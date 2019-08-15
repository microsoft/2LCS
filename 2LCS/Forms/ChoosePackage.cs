using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChoosePackage : Form
    {
        public List<DeployablePackage> Packages;
        private const int CpNocloseButton = 0x200;
        private readonly BindingSource _packagesSource = new BindingSource();
        private bool _sortAscending;

        public ChoosePackage()
        {
            InitializeComponent();
        }

        internal bool Cancelled { get; private set; }
        internal DeployablePackage DeployablePackage { get; private set; }

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

        private void ChoosePackage_Load(object sender, EventArgs e)
        {
            packagesDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = packagesDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(packagesDataGridView, true, null);
            }
            packagesDataGridView.Columns["ModifiedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            packagesDataGridView.DataSource = _packagesSource;
            if (Packages != null)
            {
                _packagesSource.DataSource = Packages.OrderBy(f => f.ModifiedDate).Reverse();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (packagesDataGridView.SelectedRows.Count > 0)
            {
                DeployablePackage = (DeployablePackage)packagesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void PackagesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (packagesDataGridView.SelectedRows.Count > 0)
            {
                DeployablePackage = (DeployablePackage)packagesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }

        private void PackagesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (packagesDataGridView.DataSource == null) return;
            _packagesSource.DataSource = _sortAscending ? Packages.OrderBy(packagesDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : Packages.OrderBy(packagesDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }
    }
}