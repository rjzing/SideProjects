using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using TagLib;

namespace MLMS
{
    //LAPTOP = DESKTOP-5M1CJVH
    //test change2
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //private void openFileMenu_Click(object sender, EventArgs e)
        //{
        //    //string filePathResult = null;
        //    OpenFileDialog openFileDia = frmMainOpenFile;
        //    List<string> filePaths = new List<string>();
        //    List<SmallClasses.MP3> tempSelectedFiles = new List<SmallClasses.MP3>();
        //    List<SmallClasses.MP3> selectedFiles = new List<SmallClasses.MP3>();
        //    //Program.openAlbums = new List<frmChild>();
        //    string tempArtists = "";
            
        //    if (Program.pcName == "DESKTOP-5M1CJVH")
        //    {
        //        openFileDia.InitialDirectory = "D:\\";
        //    }
        //    else
        //    {
        //        openFileDia.InitialDirectory = "D:\\Downloads\\MP3";
        //    }
        //    openFileDia.Filter = "(*.mp3)|*.mp3";
        //    openFileDia.FileName = "";
        //    openFileDia.ShowDialog();
        //    foreach (string individualPaths in openFileDia.FileNames)
        //    {
        //        filePaths.Add(individualPaths);
        //    }
        //    if (!string.IsNullOrEmpty(openFileDia.FileNames[0]))
        //    {
        //        int rowCount = -1;
        //        foreach (string paths in filePaths)
        //        {
        //            var tempTagLibFile = TagLib.File.Create(paths);
        //            string[] splitPaths = paths.Split('\\');
        //            int count = splitPaths.Length;
        //            string tempFileName = splitPaths[count - 1];
        //            string tempNameOfFile = tempFileName.Split('.')[0];
        //            int artistCount = tempTagLibFile.Tag.Performers.Length;
        //            tempArtists = "";
        //            for (int counter = 0; counter < artistCount; counter++)
        //            {
        //                if (counter + 1 != artistCount)
        //                {
        //                    tempArtists += tempTagLibFile.Tag.Performers[counter] + ", ";
        //                }
        //                else
        //                {
        //                    tempArtists += tempTagLibFile.Tag.Performers[counter];
        //                }
        //            }
        //            rowCount++;
        //            var tempMP3 = new SmallClasses.MP3()
        //            {
        //                OriginalRow = rowCount,
        //                FilePath = paths,
        //                FileName = tempNameOfFile,
        //                TrackNumber = Convert.ToInt16(tempTagLibFile.Tag.Track),
        //                SongTitle = tempTagLibFile.Tag.Title,
        //                Album = tempTagLibFile.Tag.Album,
        //                Artists = tempArtists
        //            };
        //            tempSelectedFiles.Add(tempMP3);
        //            //if (!Program.openArtists.ContainsKey(tempArtists))
        //            //{
                    
        //                //Program.openArtists.Add(tempArtists);
        //            //}
        //        }
        //        foreach (SmallClasses.MP3 selectedFile in tempSelectedFiles)
        //        {
        //            if (!Program.openArtists.Contains(selectedFile.Artists))
        //            {
        //                Program.openArtists.Add(selectedFile.Artists);
        //                break;
        //            }
        //        }
        //        SmallClasses.SortTracks sorting = new SmallClasses.SortTracks();
        //        tempSelectedFiles.Sort(sorting);
        //        var groupByAlbum = tempSelectedFiles.GroupBy(selectedFile => selectedFile.Album);
        //        rowCount = -1;
        //        string tempAlbum = "";
        //        foreach (var individualAlbum in groupByAlbum)
        //        {
        //            List<SmallClasses.MP3> individualAlbumTracks = new List<SmallClasses.MP3>();
        //            frmChild newChild = new frmChild();
        //            if (String.IsNullOrEmpty(individualAlbum.Key))
        //            {
        //                tempAlbum = "Unknown Album";
        //            }
        //            else
        //            {
        //                tempAlbum = individualAlbum.Key;
        //            }
        //            if (!Program.openAlbums.Contains(tempAlbum))
        //            {
        //                Program.openAlbums.Add(tempAlbum);
        //            }
        //            foreach (var tempFile in individualAlbum)
        //            {
        //                rowCount++;
        //                var tempMP3 = new SmallClasses.MP3()
        //                {
        //                    OriginalRow = rowCount,
        //                    FilePath = tempFile.FilePath,
        //                    FileName = tempFile.FileName,
        //                    TrackNumber = tempFile.TrackNumber,
        //                    SongTitle = tempFile.SongTitle,
        //                    Album = tempFile.Album,
        //                    Artists = tempFile.Artists
        //                };
        //                individualAlbumTracks.Add(tempMP3);
        //                if (string.IsNullOrEmpty(tempFile.Artists))
        //                {
        //                    tempArtists = "Unknown Artist";
        //                }
        //                else
        //                {
        //                    tempArtists = tempFile.Artists;
        //                }
        //            }
        //            newChild.Text = tempArtists + " - " + tempAlbum;
        //            newChild.MdiParent = this;
        //            newChild.Show();
        //            //Program.openChildren.Add(newChild);

        //            Program.refreshDGVOnChild(individualAlbumTracks, newChild);
        //            //newChild.dgvOutput.DataSource = null;
        //            //newChild.dgvOutput.AutoResizeColumns();
        //            //newChild.dgvOutput.DataSource = individualAlbumTracks;
        //            //newChild.dgvOutput.RowHeadersVisible = false;
        //            //newChild.dgvOutput.Columns[0].Visible = false;
        //            //newChild.dgvOutput.Columns[0].HeaderText = "Original Row";
        //            //newChild.dgvOutput.Columns[1].Visible = false;
        //            //newChild.dgvOutput.Columns[1].HeaderText = "File Path";
        //            //newChild.dgvOutput.Columns[2].HeaderText = "File Name";
        //            //newChild.dgvOutput.Columns[3].HeaderText = "Track Number";
        //            //newChild.dgvOutput.Columns[4].HeaderText = "Song Title";
        //            //newChild.dgvOutput.Columns[5].HeaderText = "Album";
        //            //newChild.dgvOutput.Columns[6].HeaderText = "Artists";
        //            //newChild.dgvOutput.AutoResizeColumns();
        //            //newChild.dgvOutput.Refresh();

        //        }
        //    }
        //    int openChildrenCount = MdiChildren.Count();
        //    Program.openChildren = new frmChild[openChildrenCount];
        //    Program.openChildren = MdiChildren.ToArray();
            
        //    //for (int counter = 0; counter < openChildrenCount; counter++)
        //    //{
        //    //    Program.openChildren[counter] = MdiChildren.ToArray();
        //    //}
        //    //dgvOutput.DataSource = null;
        //    //dgvOutput.AutoResizeColumns();
        //    //dgvOutput.DataSource = selectedFiles;
        //    //dgvOutput.RowHeadersVisible = false;
        //    //dgvOutput.Columns[0].Visible = false;
        //    //dgvOutput.Columns[0].HeaderText = "Original Row";
        //    //dgvOutput.Columns[1].Visible = false;
        //    //dgvOutput.Columns[1].HeaderText = "File Path";
        //    //dgvOutput.Columns[2].HeaderText = "File Name";
        //    //dgvOutput.Columns[3].HeaderText = "Track Number";
        //    //dgvOutput.Columns[4].HeaderText = "Song Title";
        //    //dgvOutput.Columns[5].HeaderText = "Album";
        //    //dgvOutput.Columns[6].HeaderText = "Artists";
        //    //dgvOutput.AutoResizeColumns();
        //    //dgvOutput.Refresh();
        //    //if (!String.IsNullOrEmpty(filePathResult))
        //    //{
        //    //var tagLibFile = TagLib.File.Create(filePathResult);
        //    //tagLibFile.Tag.Title = "taglib test";
        //    //tagLibFile.Tag.Album = "taglib_test";
        //    //string[] artists = new string[3];
        //    //artists[0] = "taglib-test";
        //    //artists[1] = "test";
        //    //artists[2] = "test1";
        //    //tagLibFile.Tag.Performers = artists;
        //    //tagLibFile.Tag.Track = 2;
        //    //tagLibFile.Save();
        //    //}
        //    //else
        //    //{
        //    //MessageBox.Show("No file selected");
        //    //}
        //}

        private void newArtist_Album_Click(object sender, EventArgs e)
        {
            frmNewArtist_Album addNewArtist_Album = new frmNewArtist_Album();
            addNewArtist_Album.MdiParent = this;
            addNewArtist_Album._frmMain = this;
            addNewArtist_Album.Show();
        }

        private void tileWindowMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeWindowMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void closeOpenAlbumsWindow_Click(object sender, EventArgs e)
        {

        }

        private void closeAllAlbumsWindowCloseAlbum_Click(object sender, EventArgs e)
        {
            foreach (frmChild closing in Program.openChildren)
            {
                closing.Close();
                closing.Dispose();
            }
            //Program.openChildren = null;
            Program.openArtists.Clear();
        }

        private void closeByArtistWindowCloseAlbums_Click(object sender, EventArgs e)
        {
            //foreach(frmChild closing in Program.openAlbums)
            //{
            //    string tempArtist;
            //    tempArtist = closing.Text.Split('-')[0];
            //    //if ()
            //    //{

            //    //}
            //}
            //foreach (string artist in Program.openArtists)
            //{

            //}
            //if (Program.openChildren.Length > 0 && Program.openArtists.Count > 0)
            if(Program.openArtists.Count > 0)
            {
                frmCloseBy closeByArtist = new frmCloseBy("CloseByArtist");
                closeByArtist._frmMain = this;
                closeByArtist.MdiParent = this;
                closeByArtist.Show();
            }
        }

        private void closeByAlbumWindowCloseAlbums_Click(object sender, EventArgs e)
        {
            //if (Program.openChildren.Length > 0 && Program.openAlbums.Count > 0)
            if(Program.openAlbums.Count > 0)
            {
                frmCloseBy closeByArtist = new frmCloseBy("CloseByAlbum");
                closeByArtist._frmMain = this;
                closeByArtist.MdiParent = this;
                closeByArtist.Show();
            }
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDia = frmMainOpenFile;
            List<string> filePaths = new List<string>();
            List<SmallClasses.MP3> tempSelectedFiles = new List<SmallClasses.MP3>();
            List<string> albums = new List<string>();
            List<string> tracks = new List<string>();
            string tempArtists = "";

            if (Program.pcName == "DESKTOP-5M1CJVH")
            {
                openFileDia.InitialDirectory = "D:\\";
            }
            else
            {
                openFileDia.InitialDirectory = "D:\\Downloads\\MP3";
            }
            openFileDia.Filter = "(*.mp3)|*.mp3";
            openFileDia.FileName = "";
            openFileDia.ShowDialog();
            foreach (string individualPaths in openFileDia.FileNames)
            {
                filePaths.Add(individualPaths);
            }
            frmChild newChild = new frmChild();

            newChild.trvOutput.BeginUpdate();
            newChild.trvOutput.Nodes.Clear();

            //foreach (string individualPaths in filePaths)
            //{
            //    filePaths.Add(individualPaths);
            //}
            int rowCount = -1;
            foreach (string paths in filePaths)
            {
                var tempTagLibFile = TagLib.File.Create(paths);
                string[] splitPaths = paths.Split('\\');
                int count = splitPaths.Length;
                string tempFileName = splitPaths[count - 1];
                string tempNameOfFile = tempFileName.Split('.')[0];
                int artistCount = tempTagLibFile.Tag.Performers.Length;
                tempArtists = "";
                for (int counter = 0; counter < artistCount; counter++)
                {
                    if (counter + 1 != artistCount)
                    {
                        tempArtists += tempTagLibFile.Tag.Performers[counter] + ", ";
                    }
                    else
                    {
                        tempArtists += tempTagLibFile.Tag.Performers[counter];
                    }
                }
                rowCount++;
                var tempMP3 = new SmallClasses.MP3()
                {
                    OriginalRow = rowCount,
                    FilePath = paths,
                    FileName = tempNameOfFile,
                    TrackNumber = Convert.ToInt16(tempTagLibFile.Tag.Track),
                    SongTitle = tempTagLibFile.Tag.Title,
                    Album = tempTagLibFile.Tag.Album,
                    Artists = tempArtists
                };
                tempSelectedFiles.Add(tempMP3);
                if (!Program.openArtists.Contains(tempArtists))
                {

                    Program.openArtists.Add(tempArtists);
                }
            }

            //foreach (SmallClasses.MP3 file in tempSelectedFiles)
            //{
            //    newChildList.trvOutput.Nodes.Add(new TreeNode(file.ToString()));
            //}
            //foreach (SmallClasses.MP3 file in tempSelectedFiles)
            //{
            //    if (!albums.Contains(file.Album))
            //    {
            //        albums.Add(file.Album);
            //    }
            //}

            SmallClasses.SortTracks sorting = new SmallClasses.SortTracks();
            tempSelectedFiles.Sort(sorting);
            var groupByAlbum = tempSelectedFiles.GroupBy(selectedFile => selectedFile.Album);
            rowCount = -1;
            string tempAlbum = "";
            int albumCounter = -1;
            foreach (var individualAlbum in groupByAlbum)
            {
                List<SmallClasses.MP3> individualAlbumTracks = new List<SmallClasses.MP3>();
                if (string.IsNullOrEmpty(individualAlbum.Key))
                {
                    tempAlbum = "Unknown Album";
                }
                else
                {
                    tempAlbum = individualAlbum.Key;
                }
                albumCounter++;
                newChild.trvOutput.Nodes.Add(new TreeNode(tempAlbum));

                foreach (var tempFile in individualAlbum)
                {
                    rowCount++;
                    var tempMP3 = new SmallClasses.MP3()
                    {
                        OriginalRow = rowCount,
                        FilePath = tempFile.FilePath,
                        FileName = tempFile.FileName,
                        TrackNumber = tempFile.TrackNumber,
                        SongTitle = tempFile.SongTitle,
                        Album = tempFile.Album,
                        Artists = tempFile.Artists
                    };
                    individualAlbumTracks.Add(tempMP3);
                    if (string.IsNullOrEmpty(tempFile.Artists))
                    {
                        tempArtists = "Unknown Artist";
                    }
                    else
                    {
                        tempArtists = tempFile.Artists;
                    }
                    newChild.trvOutput.Nodes[albumCounter].Nodes.Add(new TreeNode(tempMP3.TracksToString()));
                }
            }
                //int albumCounter = -1;
            //foreach (string album in albums)
            //{
            //    //albumCounter++;
            //    //newChildList.trvOutput.Nodes.Add(new TreeNode(album));
            //    foreach (SmallClasses.MP3 individualFile in tempSelectedFiles)
            //    {
            //        if (individualFile.Album == album)
            //        {
            //            //newChildList.trvOutput.Nodes[albumCounter].Nodes.Add(new TreeNode(individualFile.TracksToString()));
            //            //newChildList.trvOutput.Parent.Name = album;
            //            //newChildList.trvOutput.Nodes.Add(new TreeNode(individualFile.SongTitle));
            //        }
            //    }
            //}

            newChild.trvOutput.EndUpdate();
            newChild.MdiParent = this;
            newChild.Text = tempArtists;
            Program.openChildren.Add(newChild);
            newChild.Show();
        }
    }
}
