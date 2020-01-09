namespace LCS.Forms
{
    partial class EnvironmentChanges
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
            this.environmentChangesDataGridView = new System.Windows.Forms.DataGridView();
            this.ActionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionStatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.environmentChangesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // environmentChangesDataGridView
            // 
            this.environmentChangesDataGridView.AllowUserToAddRows = false;
            this.environmentChangesDataGridView.AllowUserToDeleteRows = false;
            this.environmentChangesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.environmentChangesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.environmentChangesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.environmentChangesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.environmentChangesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.environmentChangesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionName,
            this.ActionType,
            this.StartDate,
            this.CompletionDate,
            this.ActionStatusText});
            this.environmentChangesDataGridView.Location = new System.Drawing.Point(15, 16);
            this.environmentChangesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.environmentChangesDataGridView.Name = "environmentChangesDataGridView";
            this.environmentChangesDataGridView.RowHeadersWidth = 30;
            this.environmentChangesDataGridView.RowTemplate.Height = 28;
            this.environmentChangesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.environmentChangesDataGridView.Size = new System.Drawing.Size(1459, 456);
            this.environmentChangesDataGridView.TabIndex = 0;
            this.environmentChangesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EnvironmentChangesDataGridView_ColumnHeaderMouseClick);
            // 
            // ActionName
            // 
            this.ActionName.DataPropertyName = "Name";
            this.ActionName.FillWeight = 20F;
            this.ActionName.HeaderText = "Name";
            this.ActionName.MinimumWidth = 9;
            this.ActionName.Name = "ActionName";
            // 
            // ActionType
            // 
            this.ActionType.DataPropertyName = "ActionType";
            this.ActionType.FillWeight = 20F;
            this.ActionType.HeaderText = "Type";
            this.ActionType.MinimumWidth = 9;
            this.ActionType.Name = "ActionType";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 20F;
            this.StartDate.HeaderText = "Start date";
            this.StartDate.MinimumWidth = 9;
            this.StartDate.Name = "StartDate";
            // 
            // CompletionDate
            // 
            this.CompletionDate.DataPropertyName = "CompletionDate";
            this.CompletionDate.FillWeight = 20F;
            this.CompletionDate.HeaderText = "Completion date";
            this.CompletionDate.MinimumWidth = 9;
            this.CompletionDate.Name = "CompletionDate";
            // 
            // ActionStatusText
            // 
            this.ActionStatusText.DataPropertyName = "ActionStatusText";
            this.ActionStatusText.FillWeight = 20F;
            this.ActionStatusText.HeaderText = "Status";
            this.ActionStatusText.MinimumWidth = 9;
            this.ActionStatusText.Name = "ActionStatusText";
            // 
            // EnvironmentChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 533);
            this.Controls.Add(this.environmentChangesDataGridView);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(948, 467);
            this.Name = "EnvironmentChanges";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EnvironmentChanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.environmentChangesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView environmentChangesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionStatusText;
    }
}