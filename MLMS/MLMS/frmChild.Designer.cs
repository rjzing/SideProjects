namespace MLMS
{
    partial class frmChild
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.frmChildMenuStrip = new System.Windows.Forms.MenuStrip();
            this.frmChildOpenFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChildOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.frmChildMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(50, 44);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(671, 203);
            this.dgvOutput.TabIndex = 0;
            // 
            // frmChildMenuStrip
            // 
            this.frmChildMenuStrip.AllowMerge = false;
            this.frmChildMenuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.frmChildMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmChildOpenFileMenu});
            this.frmChildMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmChildMenuStrip.Name = "frmChildMenuStrip";
            this.frmChildMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.frmChildMenuStrip.TabIndex = 1;
            this.frmChildMenuStrip.Text = "menuStrip1";
            // 
            // frmChildOpenFileMenu
            // 
            this.frmChildOpenFileMenu.Name = "frmChildOpenFileMenu";
            this.frmChildOpenFileMenu.Size = new System.Drawing.Size(48, 20);
            this.frmChildOpenFileMenu.Text = "&Open";
            this.frmChildOpenFileMenu.Click += new System.EventHandler(this.frmChildOpenFileMenu_Click);
            // 
            // frmChildOpenFile
            // 
            this.frmChildOpenFile.FileName = "openFileDialog1";
            this.frmChildOpenFile.Multiselect = true;
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.frmChildMenuStrip);
            this.MinimizeBox = false;
            this.Name = "frmChild";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChild";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.frmChildMenuStrip.ResumeLayout(false);
            this.frmChildMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.MenuStrip frmChildMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem frmChildOpenFileMenu;
        private System.Windows.Forms.OpenFileDialog frmChildOpenFile;
    }
}