using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChooseMachine : Form
    {
        internal bool Cancelled { get; private set; }
        public List<RDPConnectionDetails> RDPConnections;
        public RDPConnectionDetails RDPConnection;
        private bool _sortAscending;
        readonly BindingSource _rdpConnectionsSource = new BindingSource();

        private const int CpNocloseButton = 0x200;

        public ChooseMachine()
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
            if (rdpConnectionsDataGridView.SelectedRows.Count > 0)
            {
                RDPConnection = (RDPConnectionDetails)rdpConnectionsDataGridView.SelectedRows[0].DataBoundItem;
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
            rdpConnectionsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = rdpConnectionsDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(rdpConnectionsDataGridView, true, null);
            }
            rdpConnectionsDataGridView.DataSource = _rdpConnectionsSource;
            if(RDPConnections != null)
            {
                _rdpConnectionsSource.DataSource = RDPConnections.OrderBy(f => f.Machine);
            }
        }

        private void PackagesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rdpConnectionsDataGridView.DataSource == null) return;
            _rdpConnectionsSource.DataSource = _sortAscending ? RDPConnections.OrderBy(rdpConnectionsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : RDPConnections.OrderBy(rdpConnectionsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }

        private void PackagesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rdpConnectionsDataGridView.SelectedRows.Count > 0)
            {
                RDPConnection = (RDPConnectionDetails)rdpConnectionsDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                Cancelled = true;
            }
            Close();
        }
    }
}
