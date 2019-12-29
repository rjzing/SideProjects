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
    }
}
