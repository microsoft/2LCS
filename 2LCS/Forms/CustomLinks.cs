using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class CustomLinks : Form
    {
        internal bool Cancelled { get; private set; }
        private List<JsonObjects.CustomLink> _linksList;
        private BindingSource _linksSource = new BindingSource();
        private bool _sortAscending = true;
        private const int CpNocloseButton = 0x200;

        public CustomLinks()
        {
            InitializeComponent();
        }

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
            Properties.Settings.Default.links = JsonConvert.SerializeObject(_linksList, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            Properties.Settings.Default.Save();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void CustomLinks_Load(object sender, EventArgs e)
        {
            linksDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = linksDataGridView.GetType();
                System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                pi.SetValue(linksDataGridView, true, null);
            }
            _linksList = JsonConvert.DeserializeObject<List<JsonObjects.CustomLink>>(Properties.Settings.Default.links);
            if(_linksList == null)
            {
                _linksList = new List<JsonObjects.CustomLink>();
            }
            _linksSource.DataSource = _linksList;
            linksDataGridView.DataSource = _linksSource;
        }

        private void LinksDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = linksDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && linksDataGridView.Rows[hti.RowIndex].Selected != true)
                {
                    linksDataGridView.ClearSelection();
                    linksDataGridView.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void LinksDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (linksDataGridView.DataSource != null && _linksList != null)
            {
                if (_sortAscending)
                    _linksSource.DataSource = _linksList.OrderBy(linksDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList();
                else
                    _linksSource.DataSource = _linksList.OrderBy(linksDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
                _sortAscending = !_sortAscending;
                linksDataGridView.ClearSelection();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var count = linksDataGridView.SelectedRows.Count;
            if(count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (!linksDataGridView.SelectedRows[0].IsNewRow)
                    {
                        linksDataGridView.Rows.RemoveAt(linksDataGridView.SelectedRows[0].Index);
                    }
                }
            }
        }
    }
}
