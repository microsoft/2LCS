namespace LCS.Forms
{
    partial class ChooseNSG
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
            this.nsgRulesDataGridView = new System.Windows.Forms.DataGridView();
            this.RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpOrCidr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nsgRulesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OkButton.Location = new System.Drawing.Point(398, 399);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(182, 33);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            // nsgRulesDataGridView
            // 
            this.nsgRulesDataGridView.AllowUserToAddRows = false;
            this.nsgRulesDataGridView.AllowUserToDeleteRows = false;
            this.nsgRulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgRulesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nsgRulesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.nsgRulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nsgRulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleName,
            this.IpOrCidr,
            this.Service,
            this.Expiration});
            this.nsgRulesDataGridView.Location = new System.Drawing.Point(12, 13);
            this.nsgRulesDataGridView.MultiSelect = false;
            this.nsgRulesDataGridView.Name = "nsgRulesDataGridView";
            this.nsgRulesDataGridView.RowHeadersVisible = false;
            this.nsgRulesDataGridView.RowHeadersWidth = 62;
            this.nsgRulesDataGridView.RowTemplate.Height = 28;
            this.nsgRulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nsgRulesDataGridView.Size = new System.Drawing.Size(1194, 380);
            this.nsgRulesDataGridView.TabIndex = 0;
            this.nsgRulesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_CellMouseDoubleClick);
            this.nsgRulesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_ColumnHeaderMouseClick);
            // 
            // RuleName
            // 
            this.RuleName.DataPropertyName = "Name";
            this.RuleName.HeaderText = "Rule name";
            this.RuleName.MinimumWidth = 8;
            this.RuleName.Name = "RuleName";
            this.RuleName.ReadOnly = true;
            // 
            // IpOrCidr
            // 
            this.IpOrCidr.DataPropertyName = "IpOrCidr";
            this.IpOrCidr.HeaderText = "IP or CIDR";
            this.IpOrCidr.MinimumWidth = 8;
            this.IpOrCidr.Name = "IpOrCidr";
            this.IpOrCidr.ReadOnly = true;
            // 
            // Service
            // 
            this.Service.DataPropertyName = "Service";
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 8;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // Expiration
            // 
            this.Expiration.DataPropertyName = "Expiration";
            this.Expiration.HeaderText = "Expiration date";
            this.Expiration.MinimumWidth = 8;
            this.Expiration.Name = "Expiration";
            this.Expiration.ReadOnly = true;
            // 
            // ChooseNSG
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1218, 444);
            this.Controls.Add(this.nsgRulesDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "ChooseNSG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose machine to connect to";
            this.Load += new System.EventHandler(this.ChoosePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nsgRulesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView nsgRulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpOrCidr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiration;
    }
}