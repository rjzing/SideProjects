namespace MLMS
{
    partial class frmEditAlbum
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.frmEditAlbumContextMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveFirstContextMen = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpContextMen = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLastContextMen = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownContextMen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.frmEditAlbumContextMen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.ContextMenuStrip = this.frmEditAlbumContextMen;
            this.dgvOutput.Location = new System.Drawing.Point(12, 12);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(616, 294);
            this.dgvOutput.TabIndex = 0;
            // 
            // frmEditAlbumContextMen
            // 
            this.frmEditAlbumContextMen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstContextMen,
            this.moveUpContextMen,
            this.moveLastContextMen,
            this.moveDownContextMen});
            this.frmEditAlbumContextMen.Name = "frmEditAlbumContextMen";
            this.frmEditAlbumContextMen.Size = new System.Drawing.Size(181, 114);
            // 
            // moveFirstContextMen
            // 
            this.moveFirstContextMen.Name = "moveFirstContextMen";
            this.moveFirstContextMen.Size = new System.Drawing.Size(180, 22);
            this.moveFirstContextMen.Text = "Move First";
            this.moveFirstContextMen.Click += new System.EventHandler(this.moveFirstContextMen_Click);
            // 
            // moveUpContextMen
            // 
            this.moveUpContextMen.Name = "moveUpContextMen";
            this.moveUpContextMen.Size = new System.Drawing.Size(180, 22);
            this.moveUpContextMen.Text = "Move Up";
            this.moveUpContextMen.Click += new System.EventHandler(this.moveUpContextMen_Click);
            // 
            // moveLastContextMen
            // 
            this.moveLastContextMen.Name = "moveLastContextMen";
            this.moveLastContextMen.Size = new System.Drawing.Size(180, 22);
            this.moveLastContextMen.Text = "Move Last";
            this.moveLastContextMen.Click += new System.EventHandler(this.moveLastContextMen_Click);
            // 
            // moveDownContextMen
            // 
            this.moveDownContextMen.Name = "moveDownContextMen";
            this.moveDownContextMen.Size = new System.Drawing.Size(180, 22);
            this.moveDownContextMen.Text = "Move Down";
            this.moveDownContextMen.Click += new System.EventHandler(this.moveDownContextMen_Click);
            // 
            // frmEditAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOutput);
            this.Name = "frmEditAlbum";
            this.Text = "frmEditAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.frmEditAlbumContextMen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.ContextMenuStrip frmEditAlbumContextMen;
        private System.Windows.Forms.ToolStripMenuItem moveFirstContextMen;
        private System.Windows.Forms.ToolStripMenuItem moveUpContextMen;
        private System.Windows.Forms.ToolStripMenuItem moveLastContextMen;
        private System.Windows.Forms.ToolStripMenuItem moveDownContextMen;
    }
}