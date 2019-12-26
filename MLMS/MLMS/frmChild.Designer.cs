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
            this.components = new System.ComponentModel.Container();
            this.trvOutput = new System.Windows.Forms.TreeView();
            this.frmChildMenuStrip = new System.Windows.Forms.MenuStrip();
            this.frmChildAddAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChildContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextEditSelectedAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChildMenuStrip.SuspendLayout();
            this.frmChildContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvOutput
            // 
            this.trvOutput.ContextMenuStrip = this.frmChildContextMenu;
            this.trvOutput.Location = new System.Drawing.Point(57, 45);
            this.trvOutput.Name = "trvOutput";
            this.trvOutput.Size = new System.Drawing.Size(344, 319);
            this.trvOutput.TabIndex = 0;
            // 
            // frmChildMenuStrip
            // 
            this.frmChildMenuStrip.AllowMerge = false;
            this.frmChildMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmChildAddAlbum});
            this.frmChildMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmChildMenuStrip.Name = "frmChildMenuStrip";
            this.frmChildMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.frmChildMenuStrip.TabIndex = 1;
            this.frmChildMenuStrip.Text = "frmChildMenStrip";
            this.frmChildMenuStrip.Visible = false;
            // 
            // frmChildAddAlbum
            // 
            this.frmChildAddAlbum.Name = "frmChildAddAlbum";
            this.frmChildAddAlbum.Size = new System.Drawing.Size(80, 20);
            this.frmChildAddAlbum.Text = "&Add Album";
            // 
            // frmChildContextMenu
            // 
            this.frmChildContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextEditSelectedAlbum});
            this.frmChildContextMenu.Name = "frmChildContextMenu";
            this.frmChildContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // contextEditSelectedAlbum
            // 
            this.contextEditSelectedAlbum.Name = "contextEditSelectedAlbum";
            this.contextEditSelectedAlbum.Size = new System.Drawing.Size(180, 22);
            this.contextEditSelectedAlbum.Text = "Edit Album";
            this.contextEditSelectedAlbum.Click += new System.EventHandler(this.contextEditSelectedAlbum_Click);
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.trvOutput);
            this.Controls.Add(this.frmChildMenuStrip);
            this.MainMenuStrip = this.frmChildMenuStrip;
            this.Name = "frmChild";
            this.Text = "frmChildList";
            this.frmChildMenuStrip.ResumeLayout(false);
            this.frmChildMenuStrip.PerformLayout();
            this.frmChildContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView trvOutput;
        private System.Windows.Forms.MenuStrip frmChildMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem frmChildAddAlbum;
        private System.Windows.Forms.ContextMenuStrip frmChildContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextEditSelectedAlbum;
    }
}