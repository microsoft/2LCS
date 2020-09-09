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
            this.alwaysLogAsAdmin = new System.Windows.Forms.CheckBox();
            this.groupBoxExportConfig.SuspendLayout();
            this.groupBoxUIConfig.SuspendLayout();
            this.groupBoxCaching.SuspendLayout();
            this.groupCHE.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoRefreshCheckBox
            // 
            this.AutoRefreshCheckBox.AutoSize = true;
            this.AutoRefreshCheckBox.Location = new System.Drawing.Point(8, 20);
            this.AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            this.AutoRefreshCheckBox.Size = new System.Drawing.Size(351, 21);
            this.AutoRefreshCheckBox.TabIndex = 0;
            this.AutoRefreshCheckBox.Text = "Auto-refresh list of instances after switching project";
            this.AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.Location = new System.Drawing.Point(312, 331);
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
            this.groupBoxExportConfig.Location = new System.Drawing.Point(12, 179);
            this.groupBoxExportConfig.Name = "groupBoxExportConfig";
            this.groupBoxExportConfig.Size = new System.Drawing.Size(463, 73);
            this.groupBoxExportConfig.TabIndex = 5;
            this.groupBoxExportConfig.TabStop = false;
            this.groupBoxExportConfig.Text = "Export instances/updates";
            // 
            // labelOrgNameExcl
            // 
            this.labelOrgNameExcl.Location = new System.Drawing.Point(4, 25);
            this.labelOrgNameExcl.Name = "labelOrgNameExcl";
            this.labelOrgNameExcl.Size = new System.Drawing.Size(241, 35);
            this.labelOrgNameExcl.TabIndex = 1;
            this.labelOrgNameExcl.Text = "Exclude projects for all organizations containing the following string\r\n\r\n";
            // 
            // textBoxProjectExcl
            // 
            this.textBoxProjectExcl.Location = new System.Drawing.Point(251, 39);
            this.textBoxProjectExcl.Name = "textBoxProjectExcl";
            this.textBoxProjectExcl.Size = new System.Drawing.Size(209, 22);
            this.textBoxProjectExcl.TabIndex = 0;
            // 
            // groupBoxUIConfig
            // 
            this.groupBoxUIConfig.Controls.Add(this.minimizeToNotificationArea);
            this.groupBoxUIConfig.Controls.Add(this.AutoRefreshCheckBox);
            this.groupBoxUIConfig.Location = new System.Drawing.Point(12, 9);
            this.groupBoxUIConfig.Name = "groupBoxUIConfig";
            this.groupBoxUIConfig.Size = new System.Drawing.Size(463, 81);
            this.groupBoxUIConfig.TabIndex = 6;
            this.groupBoxUIConfig.TabStop = false;
            this.groupBoxUIConfig.Text = "UI";
            // 
            // minimizeToNotificationArea
            // 
            this.minimizeToNotificationArea.AutoSize = true;
            this.minimizeToNotificationArea.Location = new System.Drawing.Point(7, 46);
            this.minimizeToNotificationArea.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeToNotificationArea.Name = "minimizeToNotificationArea";
            this.minimizeToNotificationArea.Size = new System.Drawing.Size(335, 21);
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
            this.groupBoxCaching.Name = "groupBoxCaching";
            this.groupBoxCaching.Size = new System.Drawing.Size(463, 79);
            this.groupBoxCaching.TabIndex = 7;
            this.groupBoxCaching.TabStop = false;
            this.groupBoxCaching.Text = "Caching";
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Location = new System.Drawing.Point(314, 40);
            this.ClearCacheButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.StoreCacheCheckBox.Location = new System.Drawing.Point(5, 45);
            this.StoreCacheCheckBox.Name = "StoreCacheCheckBox";
            this.StoreCacheCheckBox.Size = new System.Drawing.Size(276, 21);
            this.StoreCacheCheckBox.TabIndex = 1;
            this.StoreCacheCheckBox.Text = "Save cache on exit and load on startup";
            this.StoreCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // CachingEnabledCheckbox
            // 
            this.CachingEnabledCheckbox.AutoSize = true;
            this.CachingEnabledCheckbox.Location = new System.Drawing.Point(5, 20);
            this.CachingEnabledCheckbox.Name = "CachingEnabledCheckbox";
            this.CachingEnabledCheckbox.Size = new System.Drawing.Size(146, 21);
            this.CachingEnabledCheckbox.TabIndex = 0;
            this.CachingEnabledCheckbox.Text = "Enabled (memory)";
            this.CachingEnabledCheckbox.UseVisualStyleBackColor = true;
            this.CachingEnabledCheckbox.CheckedChanged += new System.EventHandler(this.CachingEnabledCheckbox_CheckedChanged);
            // 
            // groupCHE
            // 
            this.groupCHE.Controls.Add(this.alwaysLogAsAdmin);
            this.groupCHE.Location = new System.Drawing.Point(13, 259);
            this.groupCHE.Margin = new System.Windows.Forms.Padding(4);
            this.groupCHE.Name = "groupCHE";
            this.groupCHE.Padding = new System.Windows.Forms.Padding(4);
            this.groupCHE.Size = new System.Drawing.Size(462, 58);
            this.groupCHE.TabIndex = 9;
            this.groupCHE.TabStop = false;
            this.groupCHE.Text = "Cloud-hosted environments";
            // 
            // alwaysLogAsAdmin
            // 
            this.alwaysLogAsAdmin.Location = new System.Drawing.Point(7, 22);
            this.alwaysLogAsAdmin.Name = "alwaysLogAsAdmin";
            this.alwaysLogAsAdmin.Size = new System.Drawing.Size(204, 24);
            this.alwaysLogAsAdmin.TabIndex = 0;
            this.alwaysLogAsAdmin.Text = "Always log as admin user";
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 369);
            this.Controls.Add(this.groupBoxUIConfig);
            this.Controls.Add(this.groupBoxCaching);
            this.Controls.Add(this.groupBoxExportConfig);
            this.Controls.Add(this.groupCHE);
            this.Controls.Add(this.closeButton);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
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
    }
}