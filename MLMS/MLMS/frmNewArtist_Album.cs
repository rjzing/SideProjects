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
            bool albumArtistExist = false;
            if (!string.IsNullOrEmpty(txtArtist.Text))
            {
                if (string.IsNullOrEmpty(txtAlbum.Text))
                {
                    txtAlbum.Text = "Unknown Album";
                }
                if (!Program.openArtists.Contains(txtArtist.Text))
                {
                    Program.openArtists.Add(txtArtist.Text);
                    frmChild newChild = new frmChild
                    {
                        Text = txtArtist.Text
                    };
                    newChild.trvOutput.BeginUpdate();
                    newChild.trvOutput.Nodes.Add(txtAlbum.Text);
                    newChild.trvOutput.EndUpdate();
                    newChild.MdiParent = _frmMain;
                    newChild.Show();
                }
                else if (Program.openArtists.Contains(txtArtist.Text))
                {
                    foreach (SmallClasses.AlbumsByArtist tempAlbumArtist in Program.albumsByArtists)
                    {
                        if (tempAlbumArtist.album == txtAlbum.Text && tempAlbumArtist.artist == txtArtist.Text)
                        {
                            MessageBox.Show("Artist and album combo already exists");
                            albumArtistExist = true;
                            break;
                        }
                        else
                        {
                            albumArtistExist = false;
                        }
                    }
                    if (!albumArtistExist)
                    {
                        //MessageBox.Show("New album from artist detected");
                        frmChild currentArtist = new frmChild();
                        foreach (frmChild currentChild in Program.openChildren)
                        {
                            if (currentChild.Text == txtArtist.Text)
                            {
                                currentArtist = currentChild;
                                break;
                            }
                        }
                        //currentArtist.Focus();
                        //var currentNodes = currentArtist.trvOutput.Nodes;
                        currentArtist.trvOutput.BeginUpdate();
                        currentArtist.trvOutput.Nodes.Add(txtAlbum.Text);
                        currentArtist.trvOutput.EndUpdate();
                    }
                    
                }
                this.Close();
                //frmChildNewAA.Text = txtArtist.Text + " - " + txtAlbum.Text;
                //frmChildNewAA.Show();
                //Program.openChildren.Add(frmChildNewAA);
                //Program.openAlbums.Add(txtAlbum.Text);
                //Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
                //Program.openChildren = _frmMain.MdiChildren.ToArray();
            }
            //else if (!string.IsNullOrEmpty(txtArtist.Text) && string.IsNullOrEmpty(txtAlbum.Text))
            //{
            //    txtAlbum.Text = "Unknown Album";
            //    if (!Program.openArtists.Contains(txtArtist.Text))
            //    {
            //        Program.openArtists.Add(txtArtist.Text);
            //        frmChild newChild = new frmChild();
            //        newChild.Text = txtArtist.Text;
            //        newChild.trvOutput.BeginUpdate();
            //        newChild.trvOutput.Nodes.Add(txtAlbum.Text);
            //        newChild.trvOutput.EndUpdate();
            //        newChild.MdiParent = _frmMain;
            //        newChild.Show();
            //    }
            //    else if (Program.openArtists.Contains(txtArtist.Text))
            //    {
            //        foreach (SmallClasses.AlbumsByArtist tempAlbumArtist in Program.albumsByArtists)
            //        {
            //            if (tempAlbumArtist.album == txtAlbum.Text && tempAlbumArtist.artist == txtArtist.Text)
            //            {
            //                MessageBox.Show("Artist and album combo already exists");
            //                albumArtistExist = true;
            //                break;
            //            }
            //            else
            //            {
            //                albumArtistExist = false;
            //            }
            //        }
            //        if (!albumArtistExist)
            //        {
            //            //MessageBox.Show("New album from artist detected");
            //            frmChild currentArtist = new frmChild();
            //            foreach (frmChild currentChild in Program.openChildren)
            //            {
            //                if (currentChild.Text == txtArtist.Text)
            //                {
            //                    currentArtist = currentChild;
            //                    break;
            //                }
            //            }
            //            //currentArtist.Focus();
            //            //var currentNodes = currentArtist.trvOutput.Nodes;
            //            currentArtist.trvOutput.BeginUpdate();
            //            currentArtist.trvOutput.Nodes.Add(txtAlbum.Text);
            //            currentArtist.trvOutput.EndUpdate();
            //        }

            //    }
            //    this.Close();
            //}
        }
    }
}
