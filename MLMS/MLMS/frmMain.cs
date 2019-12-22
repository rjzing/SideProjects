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
    //test change
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            //string filePathResult = null;
            OpenFileDialog openFileDia = frmMainOpenFile;
            List<string> filePaths = new List<string>();
            List<SmallClasses.MP3> tempSelectedFiles = new List<SmallClasses.MP3>();
            List<SmallClasses.MP3> selectedFiles = new List<SmallClasses.MP3>();
            //Program.openAlbums = new List<frmChild>();
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
            if (!string.IsNullOrEmpty(openFileDia.FileNames[0]))
            {
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
                }
                SmallClasses.SortTracks sorting = new SmallClasses.SortTracks();
                tempSelectedFiles.Sort(sorting);
                var groupByAlbum = tempSelectedFiles.GroupBy(selectedFile => selectedFile.Album);
                rowCount = -1;
                string tempAlbum = "";
                foreach (var individualAlbum in groupByAlbum)
                {
                    List<SmallClasses.MP3> individualAlbumTracks = new List<SmallClasses.MP3>();
                    frmChild newChild = new frmChild();
                    if (String.IsNullOrEmpty(individualAlbum.Key))
                    {
                        tempAlbum = "Unknown Album";
                    }
                    else
                    {
                        tempAlbum = individualAlbum.Key;
                    }
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
                    }
                    newChild.Text = tempArtists + " - " + tempAlbum;
                    newChild.MdiParent = this;
                    newChild.Show();
                    Program.openAlbums.Add(newChild);

                    Program.refreshDGVOnChild(individualAlbumTracks, newChild);
                    //newChild.dgvOutput.DataSource = null;
                    //newChild.dgvOutput.AutoResizeColumns();
                    //newChild.dgvOutput.DataSource = individualAlbumTracks;
                    //newChild.dgvOutput.RowHeadersVisible = false;
                    //newChild.dgvOutput.Columns[0].Visible = false;
                    //newChild.dgvOutput.Columns[0].HeaderText = "Original Row";
                    //newChild.dgvOutput.Columns[1].Visible = false;
                    //newChild.dgvOutput.Columns[1].HeaderText = "File Path";
                    //newChild.dgvOutput.Columns[2].HeaderText = "File Name";
                    //newChild.dgvOutput.Columns[3].HeaderText = "Track Number";
                    //newChild.dgvOutput.Columns[4].HeaderText = "Song Title";
                    //newChild.dgvOutput.Columns[5].HeaderText = "Album";
                    //newChild.dgvOutput.Columns[6].HeaderText = "Artists";
                    //newChild.dgvOutput.AutoResizeColumns();
                    //newChild.dgvOutput.Refresh();

                }
            }

            //dgvOutput.DataSource = null;
            //dgvOutput.AutoResizeColumns();
            //dgvOutput.DataSource = selectedFiles;
            //dgvOutput.RowHeadersVisible = false;
            //dgvOutput.Columns[0].Visible = false;
            //dgvOutput.Columns[0].HeaderText = "Original Row";
            //dgvOutput.Columns[1].Visible = false;
            //dgvOutput.Columns[1].HeaderText = "File Path";
            //dgvOutput.Columns[2].HeaderText = "File Name";
            //dgvOutput.Columns[3].HeaderText = "Track Number";
            //dgvOutput.Columns[4].HeaderText = "Song Title";
            //dgvOutput.Columns[5].HeaderText = "Album";
            //dgvOutput.Columns[6].HeaderText = "Artists";
            //dgvOutput.AutoResizeColumns();
            //dgvOutput.Refresh();
            //if (!String.IsNullOrEmpty(filePathResult))
            //{
            //var tagLibFile = TagLib.File.Create(filePathResult);
            //tagLibFile.Tag.Title = "taglib test";
            //tagLibFile.Tag.Album = "taglib_test";
            //string[] artists = new string[3];
            //artists[0] = "taglib-test";
            //artists[1] = "test";
            //artists[2] = "test1";
            //tagLibFile.Tag.Performers = artists;
            //tagLibFile.Tag.Track = 2;
            //tagLibFile.Save();
            //}
            //else
            //{
            //MessageBox.Show("No file selected");
            //}
        }

        private void newArtist_Album_Click(object sender, EventArgs e)
        {
            frmNewArtist_Album addNewArtist_Album = new frmNewArtist_Album();
            addNewArtist_Album.MdiParent = this;
            addNewArtist_Album._mainForm = this;
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
            foreach (frmChild closing in Program.openAlbums)
            {
                closing.Close();
                closing.Dispose();
            }
        }
    }
}
