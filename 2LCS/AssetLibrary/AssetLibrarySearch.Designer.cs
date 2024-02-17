namespace LCS.AssetLibrary
{
    partial class AssetLibrarySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetLibrarySearch));
            assetsCreatedAfter = new System.Windows.Forms.DateTimePicker();
            assetsCreatedBefore = new System.Windows.Forms.DateTimePicker();
            assetsCreatedAfterLabel = new System.Windows.Forms.Label();
            assetsCreatedBeforeLabel = new System.Windows.Forms.Label();
            nugetPackagesFilesGroup = new System.Windows.Forms.GroupBox();
            searchApplicationVersionLabel = new System.Windows.Forms.Label();
            searchPlatformVersionLabel = new System.Windows.Forms.Label();
            searchApplicationVersion = new System.Windows.Forms.TextBox();
            searchPlatformVersion = new System.Windows.Forms.TextBox();
            searchNameOrDescriptionLabel = new System.Windows.Forms.Label();
            searchNameOrDescription = new System.Windows.Forms.TextBox();
            search = new System.Windows.Forms.Button();
            assetExportProgress = new System.Windows.Forms.ProgressBar();
            assetExportProgressNumberOfMax = new System.Windows.Forms.Label();
            assetExportProgressAssetName = new System.Windows.Forms.Label();
            nugetPackagesFilesGroup.SuspendLayout();
            SuspendLayout();
            // 
            // assetsCreatedAfter
            // 
            assetsCreatedAfter.Location = new System.Drawing.Point(157, 12);
            assetsCreatedAfter.Name = "assetsCreatedAfter";
            assetsCreatedAfter.Size = new System.Drawing.Size(250, 27);
            assetsCreatedAfter.TabIndex = 0;
            // 
            // assetsCreatedBefore
            // 
            assetsCreatedBefore.Location = new System.Drawing.Point(583, 12);
            assetsCreatedBefore.Name = "assetsCreatedBefore";
            assetsCreatedBefore.Size = new System.Drawing.Size(250, 27);
            assetsCreatedBefore.TabIndex = 1;
            assetsCreatedBefore.Value = new System.DateTime(2024, 2, 17, 14, 36, 55, 0);
            // 
            // assetsCreatedAfterLabel
            // 
            assetsCreatedAfterLabel.AutoSize = true;
            assetsCreatedAfterLabel.Location = new System.Drawing.Point(12, 17);
            assetsCreatedAfterLabel.Name = "assetsCreatedAfterLabel";
            assetsCreatedAfterLabel.Size = new System.Drawing.Size(139, 20);
            assetsCreatedAfterLabel.TabIndex = 2;
            assetsCreatedAfterLabel.Text = "Assets created after";
            // 
            // assetsCreatedBeforeLabel
            // 
            assetsCreatedBeforeLabel.AutoSize = true;
            assetsCreatedBeforeLabel.Location = new System.Drawing.Point(425, 17);
            assetsCreatedBeforeLabel.Name = "assetsCreatedBeforeLabel";
            assetsCreatedBeforeLabel.Size = new System.Drawing.Size(152, 20);
            assetsCreatedBeforeLabel.TabIndex = 3;
            assetsCreatedBeforeLabel.Text = "Assets created before";
            // 
            // nugetPackagesFilesGroup
            // 
            nugetPackagesFilesGroup.Controls.Add(searchApplicationVersionLabel);
            nugetPackagesFilesGroup.Controls.Add(searchPlatformVersionLabel);
            nugetPackagesFilesGroup.Controls.Add(searchApplicationVersion);
            nugetPackagesFilesGroup.Controls.Add(searchPlatformVersion);
            nugetPackagesFilesGroup.Location = new System.Drawing.Point(12, 87);
            nugetPackagesFilesGroup.Name = "nugetPackagesFilesGroup";
            nugetPackagesFilesGroup.Size = new System.Drawing.Size(821, 99);
            nugetPackagesFilesGroup.TabIndex = 4;
            nugetPackagesFilesGroup.TabStop = false;
            nugetPackagesFilesGroup.Text = "NuGet packages files";
            nugetPackagesFilesGroup.Visible = false;
            // 
            // searchApplicationVersionLabel
            // 
            searchApplicationVersionLabel.AutoSize = true;
            searchApplicationVersionLabel.Location = new System.Drawing.Point(6, 62);
            searchApplicationVersionLabel.Name = "searchApplicationVersionLabel";
            searchApplicationVersionLabel.Size = new System.Drawing.Size(137, 20);
            searchApplicationVersionLabel.TabIndex = 3;
            searchApplicationVersionLabel.Text = "Application version";
            // 
            // searchPlatformVersionLabel
            // 
            searchPlatformVersionLabel.AutoSize = true;
            searchPlatformVersionLabel.Location = new System.Drawing.Point(6, 29);
            searchPlatformVersionLabel.Name = "searchPlatformVersionLabel";
            searchPlatformVersionLabel.Size = new System.Drawing.Size(117, 20);
            searchPlatformVersionLabel.TabIndex = 2;
            searchPlatformVersionLabel.Text = "Platform version";
            // 
            // searchApplicationVersion
            // 
            searchApplicationVersion.Location = new System.Drawing.Point(145, 59);
            searchApplicationVersion.Name = "searchApplicationVersion";
            searchApplicationVersion.Size = new System.Drawing.Size(250, 27);
            searchApplicationVersion.TabIndex = 1;
            searchApplicationVersion.Text = "10.0.1725.159";
            // 
            // searchPlatformVersion
            // 
            searchPlatformVersion.Location = new System.Drawing.Point(145, 26);
            searchPlatformVersion.Name = "searchPlatformVersion";
            searchPlatformVersion.Size = new System.Drawing.Size(250, 27);
            searchPlatformVersion.TabIndex = 0;
            searchPlatformVersion.Text = "7.0.7068.158";
            // 
            // searchNameOrDescriptionLabel
            // 
            searchNameOrDescriptionLabel.AutoSize = true;
            searchNameOrDescriptionLabel.Location = new System.Drawing.Point(12, 48);
            searchNameOrDescriptionLabel.Name = "searchNameOrDescriptionLabel";
            searchNameOrDescriptionLabel.Size = new System.Drawing.Size(145, 20);
            searchNameOrDescriptionLabel.TabIndex = 5;
            searchNameOrDescriptionLabel.Text = "Name or description";
            searchNameOrDescriptionLabel.Visible = false;
            // 
            // searchNameOrDescription
            // 
            searchNameOrDescription.Location = new System.Drawing.Point(157, 45);
            searchNameOrDescription.Name = "searchNameOrDescription";
            searchNameOrDescription.Size = new System.Drawing.Size(250, 27);
            searchNameOrDescription.TabIndex = 6;
            searchNameOrDescription.Visible = false;
            // 
            // search
            // 
            search.Location = new System.Drawing.Point(373, 288);
            search.Name = "search";
            search.Size = new System.Drawing.Size(94, 29);
            search.TabIndex = 7;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // assetExportProgress
            // 
            assetExportProgress.Location = new System.Drawing.Point(239, 192);
            assetExportProgress.Name = "assetExportProgress";
            assetExportProgress.Size = new System.Drawing.Size(367, 29);
            assetExportProgress.TabIndex = 8;
            // 
            // assetExportProgressNumberOfMax
            // 
            assetExportProgressNumberOfMax.Location = new System.Drawing.Point(335, 224);
            assetExportProgressNumberOfMax.Name = "assetExportProgressNumberOfMax";
            assetExportProgressNumberOfMax.Size = new System.Drawing.Size(169, 20);
            assetExportProgressNumberOfMax.TabIndex = 9;
            assetExportProgressNumberOfMax.Text = "                                        ";
            assetExportProgressNumberOfMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetExportProgressAssetName
            // 
            assetExportProgressAssetName.AutoSize = true;
            assetExportProgressAssetName.Location = new System.Drawing.Point(335, 244);
            assetExportProgressAssetName.Name = "assetExportProgressAssetName";
            assetExportProgressAssetName.Size = new System.Drawing.Size(169, 20);
            assetExportProgressAssetName.TabIndex = 10;
            assetExportProgressAssetName.Text = "                                        ";
            assetExportProgressAssetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AssetLibrarySearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(841, 329);
            Controls.Add(assetExportProgressAssetName);
            Controls.Add(assetExportProgressNumberOfMax);
            Controls.Add(assetExportProgress);
            Controls.Add(search);
            Controls.Add(searchNameOrDescription);
            Controls.Add(searchNameOrDescriptionLabel);
            Controls.Add(nugetPackagesFilesGroup);
            Controls.Add(assetsCreatedBeforeLabel);
            Controls.Add(assetsCreatedAfterLabel);
            Controls.Add(assetsCreatedBefore);
            Controls.Add(assetsCreatedAfter);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "AssetLibrarySearch";
            Text = "Asset library search";
            Load += AssetLibrarySearch_Load;
            nugetPackagesFilesGroup.ResumeLayout(false);
            nugetPackagesFilesGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker assetsCreatedAfter;
        private System.Windows.Forms.DateTimePicker assetsCreatedBefore;
        private System.Windows.Forms.Label assetsCreatedAfterLabel;
        private System.Windows.Forms.Label assetsCreatedBeforeLabel;
        private System.Windows.Forms.GroupBox nugetPackagesFilesGroup;
        private System.Windows.Forms.Label searchApplicationVersionLabel;
        private System.Windows.Forms.Label searchPlatformVersionLabel;
        private System.Windows.Forms.TextBox searchApplicationVersion;
        private System.Windows.Forms.TextBox searchPlatformVersion;
        private System.Windows.Forms.Label searchNameOrDescriptionLabel;
        private System.Windows.Forms.TextBox searchNameOrDescription;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ProgressBar assetExportProgress;
        private System.Windows.Forms.Label assetExportProgressNumberOfMax;
        private System.Windows.Forms.Label assetExportProgressAssetName;
    }
}