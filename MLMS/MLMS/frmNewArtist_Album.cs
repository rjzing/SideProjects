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
    public partial class frmNewArtist_Album : Form
    {
        public frmMain _frmMain;
        public frmNewArtist_Album()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //frmChild frmChildNewAA = new frmChild();
            //frmChildNewAA.MdiParent = _frmMain;
            //if (!string.IsNullOrEmpty(txtArtist.Text) && !string.IsNullOrEmpty(txtAlbum.Text))
            //{
            //    frmChildNewAA.Text = txtArtist.Text + " - " + txtAlbum.Text;
            //    frmChildNewAA.Show();
            //    //Program.openChildren.Add(frmChildNewAA);
            //    if (!Program.openArtists.Contains(txtArtist.Text))
            //    {
            //        Program.openArtists.Add(txtArtist.Text);
            //    }
            //    Program.openAlbums.Add(txtAlbum.Text);
            //    this.Close();
            //    Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
            //    Program.openChildren = _frmMain.MdiChildren.ToArray();
            //}
            //else if (!string.IsNullOrEmpty(txtArtist.Text) && string.IsNullOrEmpty(txtAlbum.Text))
            //{
            //    frmChildNewAA.Text = txtArtist.Text + " - " + "Unknown Album";
            //    frmChildNewAA.Show();
            //    //Program.openChildren.Add(frmChildNewAA);
            //    Program.openArtists.Add(txtArtist.Text);
            //    this.Close();
            //    Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
            //    Program.openChildren = _frmMain.MdiChildren.ToArray();
            //}
            //else
            //{
            //    MessageBox.Show("Please enter an artist");
            //}

            if (!string.IsNullOrEmpty(txtArtist.Text) && !string.IsNullOrEmpty(txtAlbum.Text))
            {
                if (!Program.openArtists.Contains(txtArtist.Text))
                {
                    Program.openArtists.Add(txtArtist.Text);
                    frmChild newChild = new frmChild();
                    newChild.Text = txtArtist.Text;
                    newChild.MdiParent = _frmMain;
                    newChild.Show();
                }
                this.Close();
                //frmChildNewAA.Text = txtArtist.Text + " - " + txtAlbum.Text;
                //frmChildNewAA.Show();
                //Program.openChildren.Add(frmChildNewAA);
                //Program.openAlbums.Add(txtAlbum.Text);
                //Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
                //Program.openChildren = _frmMain.MdiChildren.ToArray();
            }
        }
    }
}
