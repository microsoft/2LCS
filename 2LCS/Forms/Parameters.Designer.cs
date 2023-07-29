namespace LCS.Forms
{
    partial class Parameters
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
            AutoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            closeButton = new System.Windows.Forms.Button();
            groupBoxExportConfig = new System.Windows.Forms.GroupBox();
            labelOrgNameExcl = new System.Windows.Forms.Label();
            textBoxProjectExcl = new System.Windows.Forms.TextBox();
            groupBoxUIConfig = new System.Windows.Forms.GroupBox();
            minimizeToNotificationArea = new System.Windows.Forms.CheckBox();
            groupBoxCaching = new System.Windows.Forms.GroupBox();
            ClearCacheButton = new System.Windows.Forms.Button();
            StoreCacheCheckBox = new System.Windows.Forms.CheckBox();
            CachingEnabledCheckbox = new System.Windows.Forms.CheckBox();
            groupCHE = new System.Windows.Forms.GroupBox();
            uriSchemeEnabled = new System.Windows.Forms.CheckBox();
            alwaysLogAsAdmin = new System.Windows.Forms.CheckBox();
            groupBoxCredentials = new System.Windows.Forms.GroupBox();
            LocalCredentialsCheckbox = new System.Windows.Forms.CheckBox();
            RDPCredentialsCheckbox = new System.Windows.Forms.CheckBox();
            groupBoxLCSUrls = new System.Windows.Forms.GroupBox();
            labelLcsUrl = new System.Windows.Forms.Label();
            textBoxLcsDiagUrl = new System.Windows.Forms.TextBox();
            textBoxLcsFixUrl = new System.Windows.Forms.TextBox();
            textBoxLcsUpdateUrl = new System.Windows.Forms.TextBox();
            textBoxLcsUrl = new System.Windows.Forms.TextBox();
            labelLcsUpdateUrl = new System.Windows.Forms.Label();
            labelLcsFixUrl = new System.Windows.Forms.Label();
            labelLcsDiagUrl = new System.Windows.Forms.Label();
            groupBoxExportConfig.SuspendLayout();
            groupBoxUIConfig.SuspendLayout();
            groupBoxCaching.SuspendLayout();
            groupCHE.SuspendLayout();
            groupBoxCredentials.SuspendLayout();
            groupBoxLCSUrls.SuspendLayout();
            SuspendLayout();
            // 
            // AutoRefreshCheckBox
            // 
            AutoRefreshCheckBox.AutoSize = true;
            AutoRefreshCheckBox.Location = new System.Drawing.Point(8, 25);
            AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            AutoRefreshCheckBox.Size = new System.Drawing.Size(371, 24);
            AutoRefreshCheckBox.TabIndex = 0;
            AutoRefreshCheckBox.Text = "Auto-refresh list of instances after switching project";
            AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            closeButton.Location = new System.Drawing.Point(312, 722);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(163, 32);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += OkButton_Click;
            // 
            // groupBoxExportConfig
            // 
            groupBoxExportConfig.Controls.Add(labelOrgNameExcl);
            groupBoxExportConfig.Controls.Add(textBoxProjectExcl);
            groupBoxExportConfig.Location = new System.Drawing.Point(12, 223);
            groupBoxExportConfig.Name = "groupBoxExportConfig";
            groupBoxExportConfig.Size = new System.Drawing.Size(463, 91);
            groupBoxExportConfig.TabIndex = 5;
            groupBoxExportConfig.TabStop = false;
            groupBoxExportConfig.Text = "Export instances/updates";
            // 
            // labelOrgNameExcl
            // 
            labelOrgNameExcl.Location = new System.Drawing.Point(4, 31);
            labelOrgNameExcl.Name = "labelOrgNameExcl";
            labelOrgNameExcl.Size = new System.Drawing.Size(241, 43);
            labelOrgNameExcl.TabIndex = 1;
            labelOrgNameExcl.Text = "Exclude projects for all organizations containing the following string\r\n\r\n";
            // 
            // textBoxProjectExcl
            // 
            textBoxProjectExcl.Location = new System.Drawing.Point(251, 38);
            textBoxProjectExcl.Name = "textBoxProjectExcl";
            textBoxProjectExcl.Size = new System.Drawing.Size(209, 27);
            textBoxProjectExcl.TabIndex = 0;
            // 
            // groupBoxUIConfig
            // 
            groupBoxUIConfig.Controls.Add(minimizeToNotificationArea);
            groupBoxUIConfig.Controls.Add(AutoRefreshCheckBox);
            groupBoxUIConfig.Location = new System.Drawing.Point(12, 11);
            groupBoxUIConfig.Name = "groupBoxUIConfig";
            groupBoxUIConfig.Size = new System.Drawing.Size(463, 102);
            groupBoxUIConfig.TabIndex = 6;
            groupBoxUIConfig.TabStop = false;
            groupBoxUIConfig.Text = "UI";
            // 
            // minimizeToNotificationArea
            // 
            minimizeToNotificationArea.AutoSize = true;
            minimizeToNotificationArea.Location = new System.Drawing.Point(8, 57);
            minimizeToNotificationArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            minimizeToNotificationArea.Name = "minimizeToNotificationArea";
            minimizeToNotificationArea.Size = new System.Drawing.Size(363, 24);
            minimizeToNotificationArea.TabIndex = 2;
            minimizeToNotificationArea.Text = "Closing the window minimizes to notification area";
            minimizeToNotificationArea.UseVisualStyleBackColor = true;
            // 
            // groupBoxCaching
            // 
            groupBoxCaching.Controls.Add(ClearCacheButton);
            groupBoxCaching.Controls.Add(StoreCacheCheckBox);
            groupBoxCaching.Controls.Add(CachingEnabledCheckbox);
            groupBoxCaching.Location = new System.Drawing.Point(12, 118);
            groupBoxCaching.Name = "groupBoxCaching";
            groupBoxCaching.Size = new System.Drawing.Size(463, 98);
            groupBoxCaching.TabIndex = 7;
            groupBoxCaching.TabStop = false;
            groupBoxCaching.Text = "Caching";
            // 
            // ClearCacheButton
            // 
            ClearCacheButton.Location = new System.Drawing.Point(315, 49);
            ClearCacheButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ClearCacheButton.Name = "ClearCacheButton";
            ClearCacheButton.Size = new System.Drawing.Size(141, 35);
            ClearCacheButton.TabIndex = 2;
            ClearCacheButton.Text = "Clear cache";
            ClearCacheButton.UseVisualStyleBackColor = true;
            ClearCacheButton.Click += ClearCacheButton_Click;
            // 
            // StoreCacheCheckBox
            // 
            StoreCacheCheckBox.AutoSize = true;
            StoreCacheCheckBox.Location = new System.Drawing.Point(8, 57);
            StoreCacheCheckBox.Name = "StoreCacheCheckBox";
            StoreCacheCheckBox.Size = new System.Drawing.Size(287, 24);
            StoreCacheCheckBox.TabIndex = 1;
            StoreCacheCheckBox.Text = "Save cache on exit and load on startup";
            StoreCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // CachingEnabledCheckbox
            // 
            CachingEnabledCheckbox.AutoSize = true;
            CachingEnabledCheckbox.Location = new System.Drawing.Point(8, 25);
            CachingEnabledCheckbox.Name = "CachingEnabledCheckbox";
            CachingEnabledCheckbox.Size = new System.Drawing.Size(154, 24);
            CachingEnabledCheckbox.TabIndex = 0;
            CachingEnabledCheckbox.Text = "Enabled (memory)";
            CachingEnabledCheckbox.UseVisualStyleBackColor = true;
            CachingEnabledCheckbox.CheckedChanged += CachingEnabledCheckbox_CheckedChanged;
            // 
            // groupCHE
            // 
            groupCHE.Controls.Add(uriSchemeEnabled);
            groupCHE.Controls.Add(alwaysLogAsAdmin);
            groupCHE.Location = new System.Drawing.Point(11, 432);
            groupCHE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupCHE.Name = "groupCHE";
            groupCHE.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupCHE.Size = new System.Drawing.Size(461, 108);
            groupCHE.TabIndex = 9;
            groupCHE.TabStop = false;
            groupCHE.Text = "Cloud-hosted environments";
            // 
            // uriSchemeEnabled
            // 
            uriSchemeEnabled.Location = new System.Drawing.Point(8, 65);
            uriSchemeEnabled.Name = "uriSchemeEnabled";
            uriSchemeEnabled.Size = new System.Drawing.Size(225, 31);
            uriSchemeEnabled.TabIndex = 1;
            uriSchemeEnabled.Text = "Enable URI scheme support";
            uriSchemeEnabled.CheckedChanged += OnUriSchemeEnabledCheckedChanged;
            // 
            // alwaysLogAsAdmin
            // 
            alwaysLogAsAdmin.Location = new System.Drawing.Point(8, 28);
            alwaysLogAsAdmin.Name = "alwaysLogAsAdmin";
            alwaysLogAsAdmin.Size = new System.Drawing.Size(204, 31);
            alwaysLogAsAdmin.TabIndex = 0;
            alwaysLogAsAdmin.Text = "Always log as admin user";
            // 
            // groupBoxCredentials
            // 
            groupBoxCredentials.Controls.Add(LocalCredentialsCheckbox);
            groupBoxCredentials.Controls.Add(RDPCredentialsCheckbox);
            groupBoxCredentials.Location = new System.Drawing.Point(11, 320);
            groupBoxCredentials.Name = "groupBoxCredentials";
            groupBoxCredentials.Size = new System.Drawing.Size(463, 105);
            groupBoxCredentials.TabIndex = 6;
            groupBoxCredentials.TabStop = false;
            groupBoxCredentials.Text = "Export project data";
            // 
            // LocalCredentialsCheckbox
            // 
            LocalCredentialsCheckbox.Location = new System.Drawing.Point(8, 63);
            LocalCredentialsCheckbox.Name = "LocalCredentialsCheckbox";
            LocalCredentialsCheckbox.Size = new System.Drawing.Size(204, 31);
            LocalCredentialsCheckbox.TabIndex = 2;
            LocalCredentialsCheckbox.Text = "Include local credentials";
            // 
            // RDPCredentialsCheckbox
            // 
            RDPCredentialsCheckbox.Location = new System.Drawing.Point(8, 26);
            RDPCredentialsCheckbox.Name = "RDPCredentialsCheckbox";
            RDPCredentialsCheckbox.Size = new System.Drawing.Size(204, 31);
            RDPCredentialsCheckbox.TabIndex = 1;
            RDPCredentialsCheckbox.Text = "Include RDP credentials";
            // 
            // groupBoxLCSUrls
            // 
            groupBoxLCSUrls.Controls.Add(labelLcsDiagUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsFixUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsUpdateUrl);
            groupBoxLCSUrls.Controls.Add(labelLcsUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsDiagUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsFixUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsUpdateUrl);
            groupBoxLCSUrls.Controls.Add(textBoxLcsUrl);
            groupBoxLCSUrls.Location = new System.Drawing.Point(11, 548);
            groupBoxLCSUrls.Name = "groupBoxLCSUrls";
            groupBoxLCSUrls.Size = new System.Drawing.Size(461, 165);
            groupBoxLCSUrls.TabIndex = 10;
            groupBoxLCSUrls.TabStop = false;
            groupBoxLCSUrls.Text = "LCS Urls";
            // 
            // labelLcsUrl
            // 
            labelLcsUrl.AutoSize = true;
            labelLcsUrl.Location = new System.Drawing.Point(9, 33);
            labelLcsUrl.Name = "labelLcsUrl";
            labelLcsUrl.Size = new System.Drawing.Size(55, 20);
            labelLcsUrl.TabIndex = 4;
            labelLcsUrl.Text = "LCS Url";
            // 
            // textBoxLcsDiagUrl
            // 
            textBoxLcsDiagUrl.Location = new System.Drawing.Point(252, 125);
            textBoxLcsDiagUrl.Name = "textBoxLcsDiagUrl";
            textBoxLcsDiagUrl.Size = new System.Drawing.Size(203, 27);
            textBoxLcsDiagUrl.TabIndex = 3;
            // 
            // textBoxLcsFixUrl
            // 
            textBoxLcsFixUrl.Location = new System.Drawing.Point(252, 92);
            textBoxLcsFixUrl.Name = "textBoxLcsFixUrl";
            textBoxLcsFixUrl.Size = new System.Drawing.Size(203, 27);
            textBoxLcsFixUrl.TabIndex = 2;
            // 
            // textBoxLcsUpdateUrl
            // 
            textBoxLcsUpdateUrl.Location = new System.Drawing.Point(252, 59);
            textBoxLcsUpdateUrl.Name = "textBoxLcsUpdateUrl";
            textBoxLcsUpdateUrl.Size = new System.Drawing.Size(203, 27);
            textBoxLcsUpdateUrl.TabIndex = 1;
            // 
            // textBoxLcsUrl
            // 
            textBoxLcsUrl.Location = new System.Drawing.Point(252, 26);
            textBoxLcsUrl.Name = "textBoxLcsUrl";
            textBoxLcsUrl.Size = new System.Drawing.Size(203, 27);
            textBoxLcsUrl.TabIndex = 0;
            // 
            // labelLcsUpdateUrl
            // 
            labelLcsUpdateUrl.AutoSize = true;
            labelLcsUpdateUrl.Location = new System.Drawing.Point(9, 66);
            labelLcsUpdateUrl.Name = "labelLcsUpdateUrl";
            labelLcsUpdateUrl.Size = new System.Drawing.Size(108, 20);
            labelLcsUpdateUrl.TabIndex = 5;
            labelLcsUpdateUrl.Text = "LCS Update Url";
            // 
            // labelLcsFixUrl
            // 
            labelLcsFixUrl.AutoSize = true;
            labelLcsFixUrl.Location = new System.Drawing.Point(9, 99);
            labelLcsFixUrl.Name = "labelLcsFixUrl";
            labelLcsFixUrl.Size = new System.Drawing.Size(139, 20);
            labelLcsFixUrl.TabIndex = 6;
            labelLcsFixUrl.Text = "LCS Issue Search Url";
            // 
            // labelLcsDiagUrl
            // 
            labelLcsDiagUrl.AutoSize = true;
            labelLcsDiagUrl.Location = new System.Drawing.Point(9, 132);
            labelLcsDiagUrl.Name = "labelLcsDiagUrl";
            labelLcsDiagUrl.Size = new System.Drawing.Size(130, 20);
            labelLcsDiagUrl.TabIndex = 7;
            labelLcsDiagUrl.Text = "LCS Diagnostic Url";
            // 
            // Parameters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 770);
            Controls.Add(groupBoxLCSUrls);
            Controls.Add(groupBoxCredentials);
            Controls.Add(groupBoxUIConfig);
            Controls.Add(groupBoxCaching);
            Controls.Add(groupBoxExportConfig);
            Controls.Add(groupCHE);
            Controls.Add(closeButton);
            Icon = Properties.Resources.favicon_blue;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Parameters";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Parameters";
            Load += Parameters_Load;
            groupBoxExportConfig.ResumeLayout(false);
            groupBoxExportConfig.PerformLayout();
            groupBoxUIConfig.ResumeLayout(false);
            groupBoxUIConfig.PerformLayout();
            groupBoxCaching.ResumeLayout(false);
            groupBoxCaching.PerformLayout();
            groupCHE.ResumeLayout(false);
            groupBoxCredentials.ResumeLayout(false);
            groupBoxLCSUrls.ResumeLayout(false);
            groupBoxLCSUrls.PerformLayout();
            ResumeLayout(false);
        }

        private void CachingEnabledCheckbox_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox AutoRefreshCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBoxExportConfig;
        private System.Windows.Forms.Label labelOrgNameExcl;
        private System.Windows.Forms.TextBox textBoxProjectExcl;
        private System.Windows.Forms.GroupBox groupBoxUIConfig;
        private System.Windows.Forms.GroupBox groupBoxCaching;
        private System.Windows.Forms.CheckBox StoreCacheCheckBox;
        private System.Windows.Forms.CheckBox CachingEnabledCheckbox;
        private System.Windows.Forms.Button ClearCacheButton;
        private System.Windows.Forms.CheckBox minimizeToNotificationArea;
        private System.Windows.Forms.GroupBox groupCHE;
        private System.Windows.Forms.CheckBox alwaysLogAsAdmin;
        private System.Windows.Forms.CheckBox uriSchemeEnabled;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.CheckBox RDPCredentialsCheckbox;
        private System.Windows.Forms.CheckBox LocalCredentialsCheckbox;
        private System.Windows.Forms.GroupBox groupBoxLCSUrls;
        private System.Windows.Forms.Label labelLcsUrl;
        private System.Windows.Forms.TextBox textBoxLcsDiagUrl;
        private System.Windows.Forms.TextBox textBoxLcsFixUrl;
        private System.Windows.Forms.TextBox textBoxLcsUpdateUrl;
        private System.Windows.Forms.TextBox textBoxLcsUrl;
        private System.Windows.Forms.Label labelLcsDiagUrl;
        private System.Windows.Forms.Label labelLcsFixUrl;
        private System.Windows.Forms.Label labelLcsUpdateUrl;
    }
}