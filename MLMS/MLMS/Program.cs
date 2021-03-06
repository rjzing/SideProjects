﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLMS
{
    static class Program
    {
        public static string pcName;
        //public static List<frmChild> openChildren;
        //public static Form[] openChildren;
        public static List<frmChild> openChildren;
        public static List<string> openArtists;
        public static List<string> openAlbums;
        public static List<SmallClasses.AlbumsByArtist> albumsByArtists;
        public static List<SmallClasses.MP3> openTracks;
        [STAThread]
        static void Main()
        {
            pcName = Environment.MachineName;
            //openChildren = new List<frmChild>();
            openChildren = new List<frmChild>();
            openArtists = new List<string>();
            openAlbums = new List<string>();
            albumsByArtists = new List<SmallClasses.AlbumsByArtist>();
            openTracks = new List<SmallClasses.MP3>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        public static void refreshDGVOnChild(List<SmallClasses.MP3> tracksIn, frmEditAlbum currentChild)
        {
            currentChild.dgvOutput.DataSource = null;
            currentChild.dgvOutput.DataSource = tracksIn;
            currentChild.dgvOutput.RowHeadersVisible = false;
            currentChild.dgvOutput.Columns[0].Visible = false;
            currentChild.dgvOutput.Columns[0].HeaderText = "Original Row";
            currentChild.dgvOutput.Columns[1].Visible = false;
            currentChild.dgvOutput.Columns[1].HeaderText = "File Path";
            currentChild.dgvOutput.Columns[2].HeaderText = "File Name";
            currentChild.dgvOutput.Columns[3].HeaderText = "Track Number";
            currentChild.dgvOutput.Columns[4].HeaderText = "Song Title";
            currentChild.dgvOutput.Columns[5].HeaderText = "Album";
            currentChild.dgvOutput.Columns[6].HeaderText = "Artists";
            currentChild.dgvOutput.AutoResizeColumns();
            currentChild.dgvOutput.Refresh();
        }

    }
}
