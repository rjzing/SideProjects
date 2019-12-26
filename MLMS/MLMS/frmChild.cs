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
        public frmMain _frmMain;
        public frmChild()
        {
            InitializeComponent();
        }

        private void contextEditSelectedAlbum_Click(object sender, EventArgs e)
        {
            var selectedAlbum = trvOutput.SelectedNode;
            List<SmallClasses.MP3> tracksOnAlbum = new List<SmallClasses.MP3>();
            string checkTrack = "";
            string artistSelected = "";
            bool albumSelected = false;
            //Track #:
            if (selectedAlbum.Text.Length >= 8)
            {
                checkTrack = selectedAlbum.Text.Substring(0, 8);
                if (checkTrack == "Track #:")
                {
                    MessageBox.Show("Please select an album");
                    albumSelected = false;
                }
                else
                {
                    albumSelected = true;
                    artistSelected = Text;
                }
            }
            else
            {
                albumSelected = true;
                artistSelected = Text;
            }
            if (albumSelected)
            {
                frmEditAlbum editThisAlbum = new frmEditAlbum
                {
                    Text = artistSelected + " - " + selectedAlbum.Text,
                    MdiParent = _frmMain
                };
                foreach(SmallClasses.MP3 tempTrack in Program.openTracks)
                {
                    if (tempTrack.Artists == artistSelected && tempTrack.Album == selectedAlbum.Text)
                    {
                        tracksOnAlbum.Add(tempTrack);
                    }
                }
                Program.refreshDGVOnChild(tracksOnAlbum, editThisAlbum);
                editThisAlbum.Show();
            }

        }
        //messageCounter ++;
        //            if (tempArtistsFromFile != tempArtistsFromText && messageCounter == 0)
        //            {
        //                var result = MessageBox.Show("Artists don't match: use artist from file?", "Mismatch Artists", MessageBoxButtons.YesNo);
        //                if(result == DialogResult.Yes)
        //                {
        //                    artistToUse = tempArtistsFromFile;
        //                }
        //                else
        //                {
        //                    artistToUse = tempArtistsFromText;
        //                }
        //            }
    }
}
