using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class UpcomingUpdates : Form
    {
        public List<Datum> Calendar;
        private readonly BindingSource _calendarSource = new BindingSource();
        private bool _sortAscending;

        public UpcomingUpdates()
        {
            InitializeComponent();
        }

        private void UpcomingUpdates_Load(object sender, EventArgs e)
        {
            upcomingUpdatesDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                var dgvType = upcomingUpdatesDataGridView.GetType();
                var pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (pi != null) pi.SetValue(upcomingUpdatesDataGridView, true, null);
            }
            upcomingUpdatesDataGridView.Columns["UtcStartDateTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            upcomingUpdatesDataGridView.DataSource = _calendarSource;
            _calendarSource.DataSource = Calendar;
        }

        private void UpcomingUpdatesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (upcomingUpdatesDataGridView.DataSource == null) return;
            _calendarSource.DataSource = _sortAscending ? Calendar.OrderBy(upcomingUpdatesDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList() : Calendar.OrderBy(upcomingUpdatesDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            _sortAscending = !_sortAscending;
        }
    }
}