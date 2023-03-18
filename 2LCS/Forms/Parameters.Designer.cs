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
            this.AutoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBoxExportConfig = new System.Windows.Forms.GroupBox();
            this.labelOrgNameExcl = new System.Windows.Forms.Label();
            this.textBoxProjectExcl = new System.Windows.Forms.TextBox();
            this.groupBoxUIConfig = new System.Windows.Forms.GroupBox();
            this.minimizeToNotificationArea = new System.Windows.Forms.CheckBox();
            this.groupBoxCaching = new System.Windows.Forms.GroupBox();
            this.ClearCacheButton = new System.Windows.Forms.Button();
            this.StoreCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.CachingEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.groupCHE = new System.Windows.Forms.GroupBox();
            this.uriSchemeEnabled = new System.Windows.Forms.CheckBox();
            this.alwaysLogAsAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLcsUrl = new System.Windows.Forms.Label();
            this.textBoxLcsUrl = new System.Windows.Forms.TextBox();
            this.labelLcsDiagUrl = new System.Windows.Forms.Label();
            this.textBoxLcsDiagUrl = new System.Windows.Forms.TextBox();
            this.labelLcsUpdateUrl = new System.Windows.Forms.Label();
            this.textBoxLcsUpdateUrl = new System.Windows.Forms.TextBox();
            this.labelLcsFixUrl = new System.Windows.Forms.Label();
            this.textBoxLcsFixUrl = new System.Windows.Forms.TextBox();
            this.groupBoxExportConfig.SuspendLayout();
            this.groupBoxUIConfig.SuspendLayout();
            this.groupBoxCaching.SuspendLayout();
            this.groupCHE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoRefreshCheckBox
            // 
            this.AutoRefreshCheckBox.AutoSize = true;
            this.AutoRefreshCheckBox.Location = new System.Drawing.Point(8, 20);
            this.AutoRefreshCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            this.AutoRefreshCheckBox.Size = new System.Drawing.Size(324, 20);
            this.AutoRefreshCheckBox.TabIndex = 0;
            this.AutoRefreshCheckBox.Text = "Auto-refresh list of instances after switching project";
            this.AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.Location = new System.Drawing.Point(312, 538);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(163, 26);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBoxExportConfig
            // 
            this.groupBoxExportConfig.Controls.Add(this.labelOrgNameExcl);
            this.groupBoxExportConfig.Controls.Add(this.textBoxProjectExcl);
            this.groupBoxExportConfig.Location = new System.Drawing.Point(12, 178);
            this.groupBoxExportConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExportConfig.Name = "groupBoxExportConfig";
            this.groupBoxExportConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExportConfig.Size = new System.Drawing.Size(463, 73);
            this.groupBoxExportConfig.TabIndex = 5;
            this.groupBoxExportConfig.TabStop = false;
            this.groupBoxExportConfig.Text = "Export instances/updates";
            // 
            // labelOrgNameExcl
            // 
            this.labelOrgNameExcl.Location = new System.Drawing.Point(4, 25);
            this.labelOrgNameExcl.Name = "labelOrgNameExcl";
            this.labelOrgNameExcl.Size = new System.Drawing.Size(241, 34);
            this.labelOrgNameExcl.TabIndex = 1;
            this.labelOrgNameExcl.Text = "Exclude projects for all organizations containing the following string\r\n\r\n";
            // 
            // textBoxProjectExcl
            // 
            this.textBoxProjectExcl.Location = new System.Drawing.Point(251, 39);
            this.textBoxProjectExcl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProjectExcl.Name = "textBoxProjectExcl";
            this.textBoxProjectExcl.Size = new System.Drawing.Size(209, 22);
            this.textBoxProjectExcl.TabIndex = 0;
            // 
            // groupBoxUIConfig
            // 
            this.groupBoxUIConfig.Controls.Add(this.minimizeToNotificationArea);
            this.groupBoxUIConfig.Controls.Add(this.AutoRefreshCheckBox);
            this.groupBoxUIConfig.Location = new System.Drawing.Point(12, 9);
            this.groupBoxUIConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUIConfig.Name = "groupBoxUIConfig";
            this.groupBoxUIConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUIConfig.Size = new System.Drawing.Size(463, 81);
            this.groupBoxUIConfig.TabIndex = 6;
            this.groupBoxUIConfig.TabStop = false;
            this.groupBoxUIConfig.Text = "UI";
            // 
            // minimizeToNotificationArea
            // 
            this.minimizeToNotificationArea.AutoSize = true;
            this.minimizeToNotificationArea.Location = new System.Drawing.Point(7, 46);
            this.minimizeToNotificationArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeToNotificationArea.Name = "minimizeToNotificationArea";
            this.minimizeToNotificationArea.Size = new System.Drawing.Size(315, 20);
            this.minimizeToNotificationArea.TabIndex = 2;
            this.minimizeToNotificationArea.Text = "Closing the window minimizes to notification area";
            this.minimizeToNotificationArea.UseVisualStyleBackColor = true;
            // 
            // groupBoxCaching
            // 
            this.groupBoxCaching.Controls.Add(this.ClearCacheButton);
            this.groupBoxCaching.Controls.Add(this.StoreCacheCheckBox);
            this.groupBoxCaching.Controls.Add(this.CachingEnabledCheckbox);
            this.groupBoxCaching.Location = new System.Drawing.Point(12, 95);
            this.groupBoxCaching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCaching.Name = "groupBoxCaching";
            this.groupBoxCaching.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCaching.Size = new System.Drawing.Size(463, 79);
            this.groupBoxCaching.TabIndex = 7;
            this.groupBoxCaching.TabStop = false;
            this.groupBoxCaching.Text = "Caching";
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Location = new System.Drawing.Point(315, 39);
            this.ClearCacheButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(141, 28);
            this.ClearCacheButton.TabIndex = 2;
            this.ClearCacheButton.Text = "Clear cache";
            this.ClearCacheButton.UseVisualStyleBackColor = true;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // StoreCacheCheckBox
            // 
            this.StoreCacheCheckBox.AutoSize = true;
            this.StoreCacheCheckBox.Location = new System.Drawing.Point(5, 46);
            this.StoreCacheCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoreCacheCheckBox.Name = "StoreCacheCheckBox";
            this.StoreCacheCheckBox.Size = new System.Drawing.Size(259, 20);
            this.StoreCacheCheckBox.TabIndex = 1;
            this.StoreCacheCheckBox.Text = "Save cache on exit and load on startup";
            this.StoreCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // CachingEnabledCheckbox
            // 
            this.CachingEnabledCheckbox.AutoSize = true;
            this.CachingEnabledCheckbox.Location = new System.Drawing.Point(5, 20);
            this.CachingEnabledCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CachingEnabledCheckbox.Name = "CachingEnabledCheckbox";
            this.CachingEnabledCheckbox.Size = new System.Drawing.Size(140, 20);
            this.CachingEnabledCheckbox.TabIndex = 0;
            this.CachingEnabledCheckbox.Text = "Enabled (memory)";
            this.CachingEnabledCheckbox.UseVisualStyleBackColor = true;
            this.CachingEnabledCheckbox.CheckedChanged += new System.EventHandler(this.CachingEnabledCheckbox_CheckedChanged);
            // 
            // groupCHE
            // 
            this.groupCHE.Controls.Add(this.uriSchemeEnabled);
            this.groupCHE.Controls.Add(this.alwaysLogAsAdmin);
            this.groupCHE.Location = new System.Drawing.Point(13, 258);
            this.groupCHE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupCHE.Name = "groupCHE";
            this.groupCHE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupCHE.Size = new System.Drawing.Size(461, 86);
            this.groupCHE.TabIndex = 9;
            this.groupCHE.TabStop = false;
            this.groupCHE.Text = "Cloud-hosted environments";
            // 
            // uriSchemeEnabled
            // 
            this.uriSchemeEnabled.Location = new System.Drawing.Point(7, 52);
            this.uriSchemeEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uriSchemeEnabled.Name = "uriSchemeEnabled";
            this.uriSchemeEnabled.Size = new System.Drawing.Size(225, 25);
            this.uriSchemeEnabled.TabIndex = 1;
            this.uriSchemeEnabled.Text = "Enable URI scheme support";
            this.uriSchemeEnabled.CheckedChanged += new System.EventHandler(this.OnUriSchemeEnabledCheckedChanged);
            // 
            // alwaysLogAsAdmin
            // 
            this.alwaysLogAsAdmin.Location = new System.Drawing.Point(7, 22);
            this.alwaysLogAsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alwaysLogAsAdmin.Name = "alwaysLogAsAdmin";
            this.alwaysLogAsAdmin.Size = new System.Drawing.Size(204, 25);
            this.alwaysLogAsAdmin.TabIndex = 0;
            this.alwaysLogAsAdmin.Text = "Always log as admin user";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLcsFixUrl);
            this.groupBox1.Controls.Add(this.textBoxLcsFixUrl);
            this.groupBox1.Controls.Add(this.labelLcsUpdateUrl);
            this.groupBox1.Controls.Add(this.textBoxLcsUpdateUrl);
            this.groupBox1.Controls.Add(this.labelLcsDiagUrl);
            this.groupBox1.Controls.Add(this.textBoxLcsDiagUrl);
            this.groupBox1.Controls.Add(this.labelLcsUrl);
            this.groupBox1.Controls.Add(this.textBoxLcsUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(463, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LCS Urls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelLcsUrl
            // 
            this.labelLcsUrl.Location = new System.Drawing.Point(4, 39);
            this.labelLcsUrl.Name = "labelLcsUrl";
            this.labelLcsUrl.Size = new System.Drawing.Size(241, 20);
            this.labelLcsUrl.TabIndex = 1;
            this.labelLcsUrl.Text = "LCS Url";
            // 
            // textBoxLcsUrl
            // 
            this.textBoxLcsUrl.Location = new System.Drawing.Point(251, 39);
            this.textBoxLcsUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLcsUrl.Name = "textBoxLcsUrl";
            this.textBoxLcsUrl.Size = new System.Drawing.Size(209, 22);
            this.textBoxLcsUrl.TabIndex = 0;
            // 
            // labelLcsDiagUrl
            // 
            this.labelLcsDiagUrl.Location = new System.Drawing.Point(4, 70);
            this.labelLcsDiagUrl.Name = "labelLcsDiagUrl";
            this.labelLcsDiagUrl.Size = new System.Drawing.Size(241, 20);
            this.labelLcsDiagUrl.TabIndex = 3;
            this.labelLcsDiagUrl.Text = "LCS Diagnostic Url";
            // 
            // textBoxLcsDiagUrl
            // 
            this.textBoxLcsDiagUrl.Location = new System.Drawing.Point(251, 70);
            this.textBoxLcsDiagUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLcsDiagUrl.Name = "textBoxLcsDiagUrl";
            this.textBoxLcsDiagUrl.Size = new System.Drawing.Size(209, 22);
            this.textBoxLcsDiagUrl.TabIndex = 2;
            // 
            // labelLcsUpdateUrl
            // 
            this.labelLcsUpdateUrl.Location = new System.Drawing.Point(4, 99);
            this.labelLcsUpdateUrl.Name = "labelLcsUpdateUrl";
            this.labelLcsUpdateUrl.Size = new System.Drawing.Size(241, 20);
            this.labelLcsUpdateUrl.TabIndex = 11;
            this.labelLcsUpdateUrl.Text = "LCS Update Url";
            // 
            // textBoxLcsUpdateUrl
            // 
            this.textBoxLcsUpdateUrl.Location = new System.Drawing.Point(251, 99);
            this.textBoxLcsUpdateUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLcsUpdateUrl.Name = "textBoxLcsUpdateUrl";
            this.textBoxLcsUpdateUrl.Size = new System.Drawing.Size(209, 22);
            this.textBoxLcsUpdateUrl.TabIndex = 10;
            // 
            // labelLcsFixUrl
            // 
            this.labelLcsFixUrl.Location = new System.Drawing.Point(4, 130);
            this.labelLcsFixUrl.Name = "labelLcsFixUrl";
            this.labelLcsFixUrl.Size = new System.Drawing.Size(241, 20);
            this.labelLcsFixUrl.TabIndex = 13;
            this.labelLcsFixUrl.Text = "LCS Issue search Url";
            // 
            // textBoxLcsFixUrl
            // 
            this.textBoxLcsFixUrl.Location = new System.Drawing.Point(251, 130);
            this.textBoxLcsFixUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLcsFixUrl.Name = "textBoxLcsFixUrl";
            this.textBoxLcsFixUrl.Size = new System.Drawing.Size(209, 22);
            this.textBoxLcsFixUrl.TabIndex = 12;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUIConfig);
            this.Controls.Add(this.groupBoxCaching);
            this.Controls.Add(this.groupBoxExportConfig);
            this.Controls.Add(this.groupCHE);
            this.Controls.Add(this.closeButton);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parameters";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.Parameters_Load);
            this.groupBoxExportConfig.ResumeLayout(false);
            this.groupBoxExportConfig.PerformLayout();
            this.groupBoxUIConfig.ResumeLayout(false);
            this.groupBoxUIConfig.PerformLayout();
            this.groupBoxCaching.ResumeLayout(false);
            this.groupBoxCaching.PerformLayout();
            this.groupCHE.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLcsUrl;
        private System.Windows.Forms.TextBox textBoxLcsUrl;
        private System.Windows.Forms.Label labelLcsFixUrl;
        private System.Windows.Forms.TextBox textBoxLcsFixUrl;
        private System.Windows.Forms.Label labelLcsUpdateUrl;
        private System.Windows.Forms.TextBox textBoxLcsUpdateUrl;
        private System.Windows.Forms.Label labelLcsDiagUrl;
        private System.Windows.Forms.TextBox textBoxLcsDiagUrl;
    }
}