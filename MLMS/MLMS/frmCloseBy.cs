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
    public partial class frmCloseBy : Form
    {
        private string closingBy;
        private List<RadioButton> radBtns;
        public frmMain _frmMain;
        public frmCloseBy(string selectedCloseBy)
        {
            closingBy = selectedCloseBy;
            radBtns = new List<RadioButton>();
            InitializeComponent();
        }
        //test desktop
        private void frmCloseBy_Load(object sender, EventArgs e)
        {
            //this.rbtn0.AutoSize = true;
            //this.rbtn0.Location = new System.Drawing.Point(3, 16);
            //this.rbtn0.Name = "rbtn0";
            //this.rbtn0.Size = new System.Drawing.Size(14, 13);
            //this.rbtn0.TabIndex = 0;
            //this.rbtn0.TabStop = true;
            //this.rbtn0.UseVisualStyleBackColor = true;
            //int counter = -1;
            //this.rbtn1.AutoSize = true;
            //this.rbtn1.Location = new System.Drawing.Point(3, 46);
            //this.rbtn1.Name = "rbtn1";
            //this.rbtn1.Size = new System.Drawing.Size(14, 13);
            //this.rbtn1.TabIndex = 1;
            //this.rbtn1.TabStop = true;
            //this.rbtn1.UseVisualStyleBackColor = true;
            if (closingBy == "CloseByArtist")
            {
                Text = "Close by Artist";
                int yLocation = 16;
                int xLocation = 3;
                foreach (string artist in Program.openArtists)
                {
                    RadioButton radBtn = new RadioButton();
                    radBtn.AutoSize = true;
                    radBtn.Location = new Point(xLocation, yLocation);
                    radBtn.Name = artist;
                    radBtn.Size = new Size(14, 13);
                    radBtn.TabIndex = 0;
                    radBtn.TabStop = true;
                    radBtn.UseVisualStyleBackColor = true;
                    radBtn.Text = artist;
                    gbxCloseBy.Controls.Add(radBtn);
                    radBtns.Add(radBtn);
                    yLocation += 30;
                }
            }

            if (closingBy == "CloseByAlbum")
            {
                Text = "Close by Album";
                int yLocation = 16;
                int xLocation = 3;
                foreach (string album in Program.openAlbums)
                {
                    RadioButton radBtn = new RadioButton();
                    radBtn.AutoSize = true;
                    radBtn.Location = new Point(xLocation, yLocation);
                    radBtn.Name = album;
                    radBtn.Size = new Size(14, 13);
                    radBtn.TabIndex = 0;
                    radBtn.TabStop = true;
                    radBtn.UseVisualStyleBackColor = true;
                    radBtn.Text = album;
                    gbxCloseBy.Controls.Add(radBtn);
                    radBtns.Add(radBtn);
                    yLocation += 30;
                    //counter++;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (closingBy == "CloseByArtist")
            {
                string artistToClose = "";
                foreach (RadioButton toCheck in radBtns)
                {
                    if (toCheck.Checked)
                    {
                        artistToClose = toCheck.Name;
                        Program.openArtists.Remove(artistToClose);
                        break;
                    }
                }
                //foreach (frmChild toClose in Program.openChildren)
                //{
                //    string tempArtist = toClose.Text.Split('-')[0];
                //    string artist = tempArtist.Trim(' ');
                //    string tempAlbum = toClose.Text.Split('-')[1];
                //    string album = tempAlbum.Trim(' ');
                //    if (artist == artistToClose)
                //    {
                //        toClose.Close();
                //        toClose.Dispose();
                //        Program.openAlbums.Remove(album);
                //    }
                //}
                int openChildren = Program.openChildren.Length;
                //int openChildren = 0;
                for (int count = 0; count < openChildren; count++)
                {
                    //if (string.IsNullOrEmpty(Program.openChildren[count].Text))
                    //{
                    //    break;
                    //}
                    string tempArtist = Program.openChildren[count].Text.Split('-')[0];
                    string artist = tempArtist.Trim(' ');
                    string tempAlbum = Program.openChildren[count].Text.Split('-')[1];
                    string album = tempAlbum.Trim(' ');
                    if (artist == artistToClose)
                    {
                        //Program.openChildren.Remove(Program.openChildren[count]);
                        
                        Program.openChildren[count].Close();
                        Program.openChildren[count].Dispose();
                        Program.openAlbums.Remove(album);
                        Program.openChildren[count] = null;
                    }
                }
                //int childrenOpen = MdiChildren.Count();
                //Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
                //Program.openChildren = _frmMain.MdiChildren.ToArray();
                //openChildren = Program.openChildren.Count;
                //for (int count = 0; count < openChildren; count++)
                //{
                //    if (string.IsNullOrEmpty(Program.openChildren[count].Text.Split('-')[0]))
                //    {
                //        break;
                //    }
                //    string tempArtist = Program.openChildren[count].Text.Split('-')[0];
                //    string artist = tempArtist.Trim(' ');
                //    string tempAlbum = Program.openChildren[count].Text.Split('-')[1];
                //    string album = tempAlbum.Trim(' ');
                //    if (artist == artistToClose)
                //    {
                //        Program.openChildren.Remove(Program.openChildren[count]);
                //        Program.openChildren[count].Close();
                //        Program.openChildren[count].Dispose();
                //        Program.openAlbums.Remove(album);
                //    }
                //}

                clearFrmChildren();
            }

            if (closingBy == "CloseByAlbum")
            {
                string albumToClose = "";
                foreach (RadioButton toCheck in radBtns)
                {
                    if (toCheck.Checked)
                    {
                        albumToClose = toCheck.Name;
                        Program.openAlbums.Remove(albumToClose);
                        break;
                    }
                }

                int openChildren = Program.openChildren.Length;
                //int openChildren = 0;
                //int test = _frmMain.MdiChildren.Count();
                for (int count = 0; count < openChildren; count++)
                {
                    //if (string.IsNullOrEmpty(Program.openChildren[count].Text))
                    //{
                    //    break;
                    //}
                    string tempArtist = Program.openChildren[count].Text.Split('-')[0];
                    string artist = tempArtist.Trim(' ');
                    string tempAlbum = Program.openChildren[count].Text.Split('-')[1];
                    string album = tempAlbum.Trim(' ');
                    if (album == albumToClose)
                    {
                        //Program.openChildren.Remove(Program.openChildren[count]);

                        Program.openChildren[count].Close();
                        Program.openChildren[count].Dispose();
                        //Program.openAlbums.Remove(album);
                        Program.openChildren[count] = null;
                    }
                }
               

                //foreach (frmChild toClose in Program.openChildren)
                //{
                //    string tempAlbum = toClose.Text.Split('-')[1];
                //    string album = tempAlbum.Trim(' ');
                //    if (album == albumToClose)
                //    {
                //        toClose.Close();
                //        toClose.Dispose();
                //    }
                //    clearFrmChildren();
                //}
                //clearFrmChildren();
            }
            //for (int count = 0; count < Program.openChildren.Count; count++)
            //{
            //    if (Program.openChildren[count].IsDisposed == true)
            //    {
            //        Program.openChildren.Remove(Program.openChildren[count]);
            //    }
            //}
            this.Close();
            Program.openChildren = new frmChild[_frmMain.MdiChildren.Count()];
            Program.openChildren = _frmMain.MdiChildren.ToArray();
        }
        private void clearFrmChildren()
        {
            //for (int count = 0; count < Program.openChildren.Count; count++)
            //{
            //    if (Program.openChildren[count].IsDisposed == true)
            //    {
            //        Program.openChildren.Remove(Program.openChildren[count]);
            //    }
            //}
            //foreach (frmChild childForm in Program.openChildren)
            //{
            //    if (childForm.IsDisposed == true)
            //    {
            //        Program.openChildren.Remove(childForm);
            //    }
            //}
        }
    }
}
