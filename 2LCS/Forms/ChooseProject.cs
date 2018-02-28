using LCS.JsonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace LCS.Forms
{
    public partial class ChooseProject : Form
    {
        internal bool Cancelled { get; private set; }
        public List<LcsProject> Projects;
        internal LcsProject LcsProject { get; private set; }
        internal HttpClientHelper HttpClientHelper { get; set; }

        private bool sortAscending = false;
        BindingSource projectsSource = new BindingSource();

        private const int CpNocloseButton = 0x200;

        public ChooseProject()
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
            if(projectsDataGridView.SelectedRows.Count > 0)
            {
                LcsProject = (LcsProject)projectsDataGridView.SelectedRows[0].DataBoundItem;
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

        private void ChooseProject_Load(object sender, EventArgs e)
        {
            projectsDataGridView.AutoGenerateColumns = false;
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = projectsDataGridView.GetType();
                System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                pi.SetValue(projectsDataGridView, true, null);
            }
            projectsDataGridView.DataSource = projectsSource;
            Projects = JsonConvert.DeserializeObject<List<LcsProject>>(Properties.Settings.Default.projects);
            if(Projects != null)
            {
                projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            }
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (projectsDataGridView.DataSource != null)
            {
                if (sortAscending)
                    projectsSource.DataSource = Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).ToList();
                else
                    projectsSource.DataSource = Projects.OrderBy(projectsDataGridView.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
                sortAscending = !sortAscending;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            List<LcsProject> favoritesSaved = new List<LcsProject>();
            if(Projects != null)
            {
                favoritesSaved = Projects.Where(x => x.Favorite == true).ToList();
            }
            Projects = HttpClientHelper.GetAllProjects();
            foreach(var savedProject in favoritesSaved)
            {
                Projects.Where(newProject => newProject.Id == savedProject.Id)
                    .Select(newProject => { newProject.Favorite = true; return newProject;} )
                        .ToList();
            }
            projectsSource.DataSource = Projects.OrderBy(f => f.Favorite).ThenBy(i => i.Id).Reverse();
            projectsSource.ResetBindings(false);
            Cursor = Cursors.Default;
        }
    }
}
