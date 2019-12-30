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
    public partial class frmEditAlbum : Form
    {
        public SmallClasses.MP3[] tracksOnAlbum;
        public frmEditAlbum()
        {
            InitializeComponent();
        }

        private void moveFirstContextMen_Click(object sender, EventArgs e)
        {
            int intIndex = 0;
            int selectedRow = Convert.ToInt32(dgvOutput.SelectedRows[intIndex].Index);
            if (selectedRow != 0)
            {
                List<SmallClasses.MP3> afterChange = new List<SmallClasses.MP3>();
                int[] newIndexes = new int[tracksOnAlbum.Length];
                int masterCounter = -1;

                for (int counter = 0; counter < tracksOnAlbum.Length; counter++)
                {
                    masterCounter++;
                    if (counter == 0)
                    {
                        newIndexes[0] = selectedRow;
                    }
                    else if (counter <= selectedRow)
                    {
                        newIndexes[masterCounter] = counter - 1;
                    }
                    else
                    {
                        newIndexes[masterCounter] = masterCounter;
                    }
                }

                for (int count = 0; count < tracksOnAlbum.Length; count++)
                {
                    int row = newIndexes[count];
                    afterChange.Add(tracksOnAlbum[row]);
                }
                Program.refreshDGVOnChild(afterChange, this);
                tracksOnAlbum = afterChange.ToArray();
            }
        }

        private void moveUpContextMen_Click(object sender, EventArgs e)
        {
            int intIndex = 0;
            int selectedRow = Convert.ToInt32(dgvOutput.SelectedRows[intIndex].Index);
            if (selectedRow != 0)
            {
                List<SmallClasses.MP3> afterChange = new List<SmallClasses.MP3>();
                int[] newIndexes = new int[tracksOnAlbum.Length];
                int masterCounter = -1;

                for (int counter = 0; counter < tracksOnAlbum.Length; counter++)
                {
                    masterCounter++;
                    if (selectedRow == counter)
                    {
                        newIndexes[masterCounter] = selectedRow - 1;
                    }
                    else if (selectedRow == counter + 1)
                    {
                        newIndexes[masterCounter] = selectedRow;
                    }
                    else
                    {
                        newIndexes[masterCounter] = masterCounter;
                    }
                }
                
                for (int count = 0; count < tracksOnAlbum.Length; count++)
                {
                    int row = newIndexes[count];
                    afterChange.Add(tracksOnAlbum[row]);
                }
                Program.refreshDGVOnChild(afterChange, this);
                tracksOnAlbum = afterChange.ToArray();
            }
        }

        private void moveDownContextMen_Click(object sender, EventArgs e)
        {
            int intIndex = 0;
            int selectedRow = Convert.ToInt32(dgvOutput.SelectedRows[intIndex].Index);
            if (selectedRow != tracksOnAlbum.Length - 1)
            {
                List<SmallClasses.MP3> afterChange = new List<SmallClasses.MP3>();
                int[] newIndexes = new int[tracksOnAlbum.Length];
                int masterCounter = -1;

                for (int counter = 0; counter < tracksOnAlbum.Length; counter++)
                {
                    masterCounter++;
                    if (selectedRow == counter)
                    {
                        newIndexes[masterCounter] = selectedRow + 1;
                    }
                    else if (selectedRow == counter - 1)
                    {
                        newIndexes[masterCounter] = selectedRow;
                    }
                    else
                    {
                        newIndexes[masterCounter] = masterCounter;
                    }
                }

                for (int count = 0; count < tracksOnAlbum.Length; count++)
                {
                    int row = newIndexes[count];
                    afterChange.Add(tracksOnAlbum[row]);
                }
                Program.refreshDGVOnChild(afterChange, this);
                tracksOnAlbum = afterChange.ToArray();
            }
        }

        private void moveLastContextMen_Click(object sender, EventArgs e)
        {
            int intIndex = 0;
            int selectedRow = Convert.ToInt32(dgvOutput.SelectedRows[intIndex].Index);
            if (selectedRow != tracksOnAlbum.Length - 1)
            {
                List<SmallClasses.MP3> afterChange = new List<SmallClasses.MP3>();
                int[] newIndexes = new int[tracksOnAlbum.Length];
                int masterCounter = -1;

                for (int counter = 0; counter < tracksOnAlbum.Length; counter++)
                {
                    masterCounter++;
                    if (counter == tracksOnAlbum.Length - 1)
                    {
                        newIndexes[tracksOnAlbum.Length - 1] = selectedRow;
                    }
                    //if (counter == 0)
                    //{
                    //    newIndexes[0] = selectedRow;
                    //}
                    else if (counter >= selectedRow)
                    {
                        newIndexes[masterCounter] = counter + 1;
                    }
                    else
                    {
                        newIndexes[masterCounter] = masterCounter;
                    }
                }

                for (int count = 0; count < tracksOnAlbum.Length; count++)
                {
                    int row = newIndexes[count];
                    afterChange.Add(tracksOnAlbum[row]);
                }
                Program.refreshDGVOnChild(afterChange, this);
                tracksOnAlbum = afterChange.ToArray();
            }
        }

        private void frmEditAlbum_Load(object sender, EventArgs e)
        {

        }

        private void addTracksFrmEditAlbum_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDia = frmEditAlbumOpenFile;
            List<string> filePaths = new List<string>();
            List<SmallClasses.MP3> tempSelectedFiles = new List<SmallClasses.MP3>();
            string frmText = Text;
            string[] splitText = new string[2];
            string tempAlbum = "";
            string tempArtists = "";
            splitText = frmText.Split('-');
            tempArtists = splitText[0].Trim(' ');
            tempAlbum = splitText[1].Trim(' ');

            if (Program.pcName == "DESKTOP-5M1CJVH")
            {
                //E:\\TestAlbum
                //openFileDia.InitialDirectory = "D:\\";
                openFileDia.InitialDirectory = "E:\\TestAlbum";
            }
            else
            {
                openFileDia.InitialDirectory = "D:\\Downloads\\MP3\\TestAlbum";
            }
            openFileDia.Filter = "(*.mp3)|*.mp3";
            openFileDia.FileName = "";
            openFileDia.ShowDialog();
            foreach (string individualPaths in openFileDia.FileNames)
            {
                filePaths.Add(individualPaths);
            }

            if (filePaths.Count > 0 && !string.IsNullOrEmpty(filePaths[0]))
            {
                tempSelectedFiles = frmMain.digestFilePaths(filePaths, false);
                
            }

            foreach (SmallClasses.MP3 individualTrack in tempSelectedFiles)
            {
                individualTrack.Album = tempAlbum;
                individualTrack.Artists = tempArtists;
            }
            Program.refreshDGVOnChild(tempSelectedFiles, this);
        }
    }
}
