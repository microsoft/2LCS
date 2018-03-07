namespace LCS.Forms
{
    partial class ChooseProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.Favorite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(398, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(586, 399);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(172, 33);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AllowUserToDeleteRows = false;
            this.projectsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Favorite,
            this.Id,
            this.ProjectName,
            this.Description,
            this.OrganizationName,
            this.CreatedByUserName});
            this.projectsDataGridView.Location = new System.Drawing.Point(12, 13);
            this.projectsDataGridView.MultiSelect = false;
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.RowHeadersVisible = false;
            this.projectsDataGridView.RowTemplate.Height = 28;
            this.projectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectsDataGridView.Size = new System.Drawing.Size(1194, 380);
            this.projectsDataGridView.TabIndex = 0;
            this.projectsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            // 
            // Favorite
            // 
            this.Favorite.DataPropertyName = "Favorite";
            this.Favorite.HeaderText = "Favorite";
            this.Favorite.Name = "Favorite";
            this.Favorite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Favorite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Project Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "Name";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // OrganizationName
            // 
            this.OrganizationName.DataPropertyName = "OrganizationName";
            this.OrganizationName.HeaderText = "Organization Name";
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            // 
            // CreatedByUserName
            // 
            this.CreatedByUserName.DataPropertyName = "CreatedByUserName";
            this.CreatedByUserName.HeaderText = "Created By";
            this.CreatedByUserName.Name = "CreatedByUserName";
            this.CreatedByUserName.ReadOnly = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(13, 399);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(152, 33);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh list";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ChooseProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1218, 444);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.projectsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "ChooseProject";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose LCS project";
            this.Load += new System.EventHandler(this.ChooseProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Favorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByUserName;
    }
}