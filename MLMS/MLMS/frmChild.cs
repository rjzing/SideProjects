using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLMS
{
    public partial class frmChild : Form
    {
        public frmChild()
        {
            InitializeComponent();
        }

        private void frmChildOpenFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDia = frmChildOpenFile;
            List<string> filePaths = new List<string>();
            List<SmallClasses.MP3> tempSelectedFiles = new List<SmallClasses.MP3>();

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
                int messageCounter = -1;
                string artistToUse = "";
                foreach (string paths in filePaths)
                {
                    var tempTagLibFile = TagLib.File.Create(paths);
                    string[] splitPaths = paths.Split('\\');
                    int count = splitPaths.Length;
                    string tempFileName = splitPaths[count - 1];
                    string tempNameOfFile = tempFileName.Split('.')[0];
                    string tempAlbumArtist = this.Text;
                    string tempArtistsFromText = tempAlbumArtist.Split('-')[0];
                    string tempAlbum = tempAlbumArtist.Split('-')[1];
                    string tempArtistsFromFile;
                    int artistCount = tempTagLibFile.Tag.Performers.Length;
                    tempArtistsFromFile = "";
                    for (int counter = 0; counter < artistCount; counter++)
                    {
                        if (counter + 1 != artistCount)
                        {
                            tempArtistsFromFile += tempTagLibFile.Tag.Performers[counter] + ", ";
                        }
                        else
                        {
                            tempArtistsFromFile += tempTagLibFile.Tag.Performers[counter];
                        }
                    }
                    messageCounter ++;
                    if (tempArtistsFromFile != tempArtistsFromText && messageCounter == 0)
                    {
                        var result = MessageBox.Show("Artists don't match: use artist from file?", "Mismatch Artists", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            artistToUse = tempArtistsFromFile;
                        }
                        else
                        {
                            artistToUse = tempArtistsFromText;
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
                        Album = tempAlbum,
                        Artists = artistToUse
                    };
                    tempSelectedFiles.Add(tempMP3);
                }
                Program.refreshDGVOnChild(tempSelectedFiles, this);
                //this.Text = artistToUse + " - " +;
            }
        }
    }
}
