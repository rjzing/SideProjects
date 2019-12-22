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
        public frmCloseBy(string selectedCloseBy)
        {
            closingBy = selectedCloseBy;
            radBtns = new List<RadioButton>();
            InitializeComponent();
        }

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
                    //counter++;
                    //if (counter == 0)
                    //{
                    //    rbtn0.Text = artist;
                    //}
                    //else
                    //{
                    //    rbtn1.Text = artist;
                    //}
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
                    //if (counter == 0)
                    //{
                    //    rbtn0.Text = artist;
                    //}
                    //else
                    //{
                    //    rbtn1.Text = artist;
                    //}
                }
            }
            //rbtn0.Text = Program.openArtists[0];
            //rbtn1.Text = Program.openArtists[1];
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
                foreach (frmChild toClose in Program.openChildren)
                {
                    string tempArtist = toClose.Text.Split('-')[0];
                    string artist = tempArtist.Trim(' ');
                    if (artist == artistToClose)
                    {
                        //Program.openChildren.Remove(toClose);
                        toClose.Close();
                        toClose.Dispose();
                    }
                }
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
                foreach (frmChild toClose in Program.openChildren)
                {
                    string tempAlbum = toClose.Text.Split('-')[1];
                    string album = tempAlbum.Trim(' ');
                    if (album == albumToClose)
                    {
                        //Program.openChildren.Remove(toClose);
                        toClose.Close();
                        toClose.Dispose();
                    }
                }
                for (int count = 0; count < Program.openChildren.Count; count++)
                {
                    if (Program.openChildren[count].Parent == null)
                    {
                        Program.openChildren.Remove(Program.openChildren[count]);
                    }
                }
            }
            this.Close();
        }
    }
}
