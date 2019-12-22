﻿namespace MLMS
{
    partial class frmMain
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
            this.frmMainOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.frmMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newArtist_Album = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOpenAlbumsWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.frmMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMainOpenFile
            // 
            this.frmMainOpenFile.FileName = "openFileDialog1";
            this.frmMainOpenFile.Multiselect = true;
            // 
            // frmMainMenuStrip
            // 
            this.frmMainMenuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.frmMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tileWindow});
            this.frmMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.frmMainMenuStrip.MdiWindowListItem = this.tileWindow;
            this.frmMainMenuStrip.Name = "frmMainMenuStrip";
            this.frmMainMenuStrip.Size = new System.Drawing.Size(947, 24);
            this.frmMainMenuStrip.TabIndex = 2;
            this.frmMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.newArtist_Album});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(179, 22);
            this.openFileMenu.Text = "&Open";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // newArtist_Album
            // 
            this.newArtist_Album.Name = "newArtist_Album";
            this.newArtist_Album.Size = new System.Drawing.Size(179, 22);
            this.newArtist_Album.Text = "&New Artist + Album";
            this.newArtist_Album.Click += new System.EventHandler(this.newArtist_Album_Click);
            // 
            // tileWindow
            // 
            this.tileWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileWindowMenu,
            this.cascadeWindowMenu,
            this.closeOpenAlbumsWindow,
            this.toolStripSeparator1});
            this.tileWindow.Name = "tileWindow";
            this.tileWindow.Size = new System.Drawing.Size(63, 20);
            this.tileWindow.Text = "&Window";
            // 
            // tileWindowMenu
            // 
            this.tileWindowMenu.Name = "tileWindowMenu";
            this.tileWindowMenu.Size = new System.Drawing.Size(180, 22);
            this.tileWindowMenu.Text = "Tile Windows";
            this.tileWindowMenu.Click += new System.EventHandler(this.tileWindowMenu_Click);
            // 
            // cascadeWindowMenu
            // 
            this.cascadeWindowMenu.Name = "cascadeWindowMenu";
            this.cascadeWindowMenu.Size = new System.Drawing.Size(180, 22);
            this.cascadeWindowMenu.Text = "Cascade Windows";
            this.cascadeWindowMenu.Click += new System.EventHandler(this.cascadeWindowMenu_Click);
            // 
            // closeOpenAlbumsWindow
            // 
            this.closeOpenAlbumsWindow.Name = "closeOpenAlbumsWindow";
            this.closeOpenAlbumsWindow.Size = new System.Drawing.Size(180, 22);
            this.closeOpenAlbumsWindow.Text = "Close Open Albums";
            this.closeOpenAlbumsWindow.Click += new System.EventHandler(this.closeOpenAlbumsWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 422);
            this.Controls.Add(this.frmMainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.frmMainMenuStrip;
            this.Name = "frmMain";
            this.Text = "MLMS Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.frmMainMenuStrip.ResumeLayout(false);
            this.frmMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog frmMainOpenFile;
        private System.Windows.Forms.MenuStrip frmMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem newArtist_Album;
        private System.Windows.Forms.ToolStripMenuItem tileWindow;
        private System.Windows.Forms.ToolStripMenuItem tileWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowMenu;
        private System.Windows.Forms.ToolStripMenuItem closeOpenAlbumsWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

