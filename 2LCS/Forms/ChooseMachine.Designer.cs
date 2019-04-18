namespace LCS.Forms
{
    partial class ChooseMachine
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
            this.rdpConnectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rdpConnectionsDataGridView)).BeginInit();
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
            // rdpConnectionsDataGridView
            // 
            this.rdpConnectionsDataGridView.AllowUserToAddRows = false;
            this.rdpConnectionsDataGridView.AllowUserToDeleteRows = false;
            this.rdpConnectionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdpConnectionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rdpConnectionsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rdpConnectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdpConnectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machine,
            this.Address,
            this.Port,
            this.Domain,
            this.Username,
            this.Password});
            this.rdpConnectionsDataGridView.Location = new System.Drawing.Point(12, 13);
            this.rdpConnectionsDataGridView.MultiSelect = false;
            this.rdpConnectionsDataGridView.Name = "rdpConnectionsDataGridView";
            this.rdpConnectionsDataGridView.RowHeadersVisible = false;
            this.rdpConnectionsDataGridView.RowHeadersWidth = 62;
            this.rdpConnectionsDataGridView.RowTemplate.Height = 28;
            this.rdpConnectionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rdpConnectionsDataGridView.Size = new System.Drawing.Size(1194, 380);
            this.rdpConnectionsDataGridView.TabIndex = 0;
            this.rdpConnectionsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_CellMouseDoubleClick);
            this.rdpConnectionsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PackagesDataGridView_ColumnHeaderMouseClick);
            // 
            // Machine
            // 
            this.Machine.DataPropertyName = "Machine";
            this.Machine.FillWeight = 15F;
            this.Machine.HeaderText = "Machine";
            this.Machine.MinimumWidth = 8;
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 30F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.DataPropertyName = "Port";
            this.Port.FillWeight = 10F;
            this.Port.HeaderText = "Port";
            this.Port.MinimumWidth = 8;
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // Domain
            // 
            this.Domain.DataPropertyName = "Domain";
            this.Domain.FillWeight = 15F;
            this.Domain.HeaderText = "Domain";
            this.Domain.MinimumWidth = 8;
            this.Domain.Name = "Domain";
            this.Domain.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 15F;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.FillWeight = 15F;
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // ChooseMachine
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1218, 444);
            this.Controls.Add(this.rdpConnectionsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 400);
            this.Name = "ChooseMachine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose machine to connect to";
            this.Load += new System.EventHandler(this.ChoosePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdpConnectionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView rdpConnectionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}