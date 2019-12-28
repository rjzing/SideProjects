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
            List<int> newIndexes = new List<int>();
            List<SmallClasses.MP3> afterChange = new List<SmallClasses.MP3>();
            int masterCounter = -1;

            for (int counter = 0; counter < tracksOnAlbum.Length; counter++)
            {
                masterCounter++;
                if (counter == 0)
                {
                    newIndexes.Add(selectedRow);
                }
                else if (counter <= selectedRow)
                {
                    newIndexes.Add(counter - 1);
                }
                else
                {
                    newIndexes.Add(masterCounter);
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
}
