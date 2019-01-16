namespace LCS.Forms
{
    partial class BuildInfoDetailsForm
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
            this.buildInfoDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalledDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Layer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallationInfoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buildInfoDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buildInfoDetailsDataGridView
            // 
            this.buildInfoDetailsDataGridView.AllowUserToAddRows = false;
            this.buildInfoDetailsDataGridView.AllowUserToDeleteRows = false;
            this.buildInfoDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildInfoDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buildInfoDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.buildInfoDetailsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.buildInfoDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildInfoDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ParentId,
            this.ModelName,
            this.InstalledDate,
            this.Version,
            this.ModuleName,
            this.Layer,
            this.InstallationInfoType,
            this.Description});
            this.buildInfoDetailsDataGridView.Location = new System.Drawing.Point(12, 13);
            this.buildInfoDetailsDataGridView.Name = "buildInfoDetailsDataGridView";
            this.buildInfoDetailsDataGridView.RowTemplate.Height = 28;
            this.buildInfoDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.buildInfoDetailsDataGridView.Size = new System.Drawing.Size(1194, 380);
            this.buildInfoDetailsDataGridView.TabIndex = 0;
            this.buildInfoDetailsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BuildInfoDetailsDataGridView_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ParentId
            // 
            this.ParentId.DataPropertyName = "ParentId";
            this.ParentId.FillWeight = 10F;
            this.ParentId.HeaderText = "Parent Id";
            this.ParentId.Name = "ParentId";
            // 
            // ModelName
            // 
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.FillWeight = 10F;
            this.ModelName.HeaderText = "Model name";
            this.ModelName.Name = "ModelName";
            // 
            // InstalledDate
            // 
            this.InstalledDate.DataPropertyName = "InstalledDate";
            this.InstalledDate.FillWeight = 10F;
            this.InstalledDate.HeaderText = "Installed date";
            this.InstalledDate.Name = "InstalledDate";
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.FillWeight = 10F;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // ModuleName
            // 
            this.ModuleName.DataPropertyName = "ModuleName";
            this.ModuleName.FillWeight = 10F;
            this.ModuleName.HeaderText = "Module name";
            this.ModuleName.Name = "ModuleName";
            // 
            // Layer
            // 
            this.Layer.DataPropertyName = "Layer";
            this.Layer.FillWeight = 10F;
            this.Layer.HeaderText = "Layer";
            this.Layer.Name = "Layer";
            // 
            // InstallationInfoType
            // 
            this.InstallationInfoType.DataPropertyName = "InstallationInfoType";
            this.InstallationInfoType.FillWeight = 10F;
            this.InstallationInfoType.HeaderText = "Installation info type";
            this.InstallationInfoType.Name = "InstallationInfoType";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 20F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // BuildInfoDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 444);
            this.Controls.Add(this.buildInfoDetailsDataGridView);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "BuildInfoDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BuildInfoDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildInfoDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView buildInfoDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalledDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Layer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallationInfoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}