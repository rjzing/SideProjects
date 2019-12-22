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
        public frmMain _mainForm;
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
            frmChild frmChildNewAA = new frmChild();
            frmChildNewAA.MdiParent = _mainForm;
            if (!string.IsNullOrEmpty(txtArtist.Text) && !string.IsNullOrEmpty(txtAlbum.Text))
            {
                frmChildNewAA.Text = txtArtist.Text + " - " + txtAlbum.Text;
                frmChildNewAA.Show();
                Program.openAlbums.Add(frmChildNewAA);
                this.Close();
            }
            else if (!string.IsNullOrEmpty(txtArtist.Text) && string.IsNullOrEmpty(txtAlbum.Text))
            {
                frmChildNewAA.Text = txtArtist.Text + " - " + "Unknown Album";
                frmChildNewAA.Show();
                Program.openAlbums.Add(frmChildNewAA);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter an artist");
            }
            
        }
    }
}
