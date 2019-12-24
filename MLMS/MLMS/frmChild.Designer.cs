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
            this.dgvOutput.Location = new System.Drawing.Point(117, 98);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(1566, 453);
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
            this.frmChildMenuStrip.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.frmChildMenuStrip.Size = new System.Drawing.Size(1867, 49);
            this.frmChildMenuStrip.TabIndex = 1;
            this.frmChildMenuStrip.Text = "menuStrip1";
            // 
            // frmChildOpenFileMenu
            // 
            this.frmChildOpenFileMenu.Name = "frmChildOpenFileMenu";
            this.frmChildOpenFileMenu.Size = new System.Drawing.Size(94, 41);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1867, 941);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.frmChildMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimizeBox = false;
            this.Name = "frmChild";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChild";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.GotFocus += new System.EventHandler(this.frmChild_Focus);
            //this.MdiChildActivate += new System.EventHandler(this.frmChild_mdiActivate);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmChild_MouseClick);
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