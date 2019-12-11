namespace LCS.Forms
{
    partial class ChoosePackage
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
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.packagesDataGridView = new System.Windows.Forms.DataGridView();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileAssetDisplayVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LcsEnvironmentActionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LcsEnvironmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OkButton.Location = new System.Drawing.Point(486, 479);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(222, 40);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(716, 479);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(210, 40);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // packagesDataGridView
            // 
            this.packagesDataGridView.AllowUserToAddRows = false;
            this.packagesDataGridView.AllowUserToDeleteRows = false;
            this.packagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packagesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.packagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageName,
            this.Description,
            this.ModifiedBy,
            this.ModifiedDate,
            this.PackageType,
            this.PlatformVersion,
            this.Publisher,
            this.PackageId,
            this.FileAssetDisplayVersion,
            this.LcsEnvironmentActionId,
            this.LcsEnvironmentId});
            this.packagesDataGridView.Location = new System.Drawing.Point(15, 16);
            this.packagesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.packagesDataGridView.MultiSelect = false;
            this.packagesDataGridView.Name = "packagesDataGridView";
            this.packagesDataGridView.RowHeadersVisible = false;
            this.packagesDataGridView.RowHeadersWidth = 62;
            this.packagesDataGridView.RowTemplate.Height = 28;
            this.packagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packagesDataGridView.Size = new System.Drawing.Size(1459, 456);
            this.packagesDataGridView.TabIndex = 0;
            this.packagesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_CellMouseDoubleClick);
            this.packagesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_ColumnHeaderMouseClick);
            // 
            // PackageName
            // 
            this.PackageName.DataPropertyName = "Name";
            this.PackageName.FillWeight = 20F;
            this.PackageName.HeaderText = "Name";
            this.PackageName.MinimumWidth = 8;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 20F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.DataPropertyName = "ModifiedBy";
            this.ModifiedBy.FillWeight = 15F;
            this.ModifiedBy.HeaderText = "Modified by";
            this.ModifiedBy.MinimumWidth = 8;
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.ReadOnly = true;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.DataPropertyName = "ModifiedDate";
            this.ModifiedDate.FillWeight = 15F;
            this.ModifiedDate.HeaderText = "Modified date";
            this.ModifiedDate.MinimumWidth = 8;
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.ReadOnly = true;
            // 
            // PackageType
            // 
            this.PackageType.DataPropertyName = "PackageType";
            this.PackageType.FillWeight = 15F;
            this.PackageType.HeaderText = "Package type";
            this.PackageType.MinimumWidth = 8;
            this.PackageType.Name = "PackageType";
            this.PackageType.ReadOnly = true;
            // 
            // PlatformVersion
            // 
            this.PlatformVersion.DataPropertyName = "PlatformVersion";
            this.PlatformVersion.FillWeight = 15F;
            this.PlatformVersion.HeaderText = "Platform version";
            this.PlatformVersion.MinimumWidth = 8;
            this.PlatformVersion.Name = "PlatformVersion";
            this.PlatformVersion.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.FillWeight = 15F;
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 8;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // PackageId
            // 
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "Package Id";
            this.PackageId.MinimumWidth = 8;
            this.PackageId.Name = "PackageId";
            this.PackageId.ReadOnly = true;
            this.PackageId.Visible = false;
            // 
            // FileAssetDisplayVersion
            // 
            this.FileAssetDisplayVersion.DataPropertyName = "FileAssetDisplayVersion";
            this.FileAssetDisplayVersion.HeaderText = "FileAssetDisplayVersion";
            this.FileAssetDisplayVersion.MinimumWidth = 8;
            this.FileAssetDisplayVersion.Name = "FileAssetDisplayVersion";
            this.FileAssetDisplayVersion.ReadOnly = true;
            this.FileAssetDisplayVersion.Visible = false;
            // 
            // LcsEnvironmentActionId
            // 
            this.LcsEnvironmentActionId.DataPropertyName = "LcsEnvironmentActionId";
            this.LcsEnvironmentActionId.HeaderText = "LcsEnvironmentActionId";
            this.LcsEnvironmentActionId.MinimumWidth = 8;
            this.LcsEnvironmentActionId.Name = "LcsEnvironmentActionId";
            this.LcsEnvironmentActionId.ReadOnly = true;
            this.LcsEnvironmentActionId.Visible = false;
            // 
            // LcsEnvironmentId
            // 
            this.LcsEnvironmentId.DataPropertyName = "LcsEnvironmentId";
            this.LcsEnvironmentId.HeaderText = "LcsEnvironmentId";
            this.LcsEnvironmentId.MinimumWidth = 8;
            this.LcsEnvironmentId.Name = "LcsEnvironmentId";
            this.LcsEnvironmentId.ReadOnly = true;
            this.LcsEnvironmentId.Visible = false;
            // 
            // ChoosePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1489, 533);
            this.Controls.Add(this.packagesDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(948, 467);
            this.Name = "ChoosePackage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose package to deploy";
            this.Load += new System.EventHandler(this.ChoosePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView packagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileAssetDisplayVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LcsEnvironmentActionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LcsEnvironmentId;
    }
}