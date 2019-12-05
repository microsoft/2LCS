namespace LCS.Forms
{
    partial class Credentials
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
            this.credentialsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // credentialsDataGridView
            // 
            this.credentialsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.credentialsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.credentialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.credentialsDataGridView.Location = new System.Drawing.Point(20, 20);
            this.credentialsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.credentialsDataGridView.Name = "credentialsDataGridView";
            this.credentialsDataGridView.RowHeadersWidth = 62;
            this.credentialsDataGridView.Size = new System.Drawing.Size(646, 357);
            this.credentialsDataGridView.TabIndex = 0;
            // 
            // Credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.credentialsDataGridView);
            this.Icon = global::LCS.Properties.Resources.favicon_blue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 320);
            this.Name = "Credentials";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credentials";
            this.Load += new System.EventHandler(this.Credentials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.credentialsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView credentialsDataGridView;
    }
}