using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LotteryApplication
{
    public partial class drawAdminForm : MetroFramework.Forms.MetroForm
    {
        public drawAdminForm()
        {
            InitializeComponent();
        }

        private void realtimeDrawBG_Load(object sender, EventArgs e)
        {
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            drawsTableAdapter1.getLatestDraw(lottoDatabaseDataSet1.draws);

            int[] unsortedDraw = new int[5];

            DateTime todaysDate = System.DateTime.Now;
            DateTime latestDraw = Convert.ToDateTime(lottoDatabaseDataSet1.draws.Rows[0][1]);

            if ((todaysDate == latestDraw) || (todaysDate > latestDraw))
            {
                drawsTableAdapter1.getLatestDraw(lottoDatabaseDataSet1.draws); //filter table
                //see query in table adapter
                String draw = realtimeDraw.drawNumbers(49, 5) + ","; //draw instance - the extra comma is so the end number is actually counted when completing the draw.
                int drawLength = draw.Length; //get length of string
                int ballSequence = 2; //seq will go 2 to 6
                string currentBall = "";
                for (int i = 0; i < drawLength; i++)
                {
                    if (draw[i].ToString() != ",")
                    {
                        //builds strings of 1 or 2 characters
                        currentBall = currentBall + draw[i].ToString();
                    }
                    else
                    {
                        //delimiter reached so update datatable
                        //ball sequence is column number in datatable
                        lottoDatabaseDataSet1.draws.Rows[0][ballSequence] = Convert.ToInt32(currentBall);
                        currentBall = "";
                        ballSequence++;
                    }
                }

                int DSIndex;
                DSIndex = 2;

                for (int x = 0; x < 5; x++)
                {
                    // The below code inserts numbers into every index in the array from the data set.
                    unsortedDraw[x] = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[0][DSIndex]);
                    DSIndex++;
                }

                for (int p = 1; p < 5; p++)
                {
                    int j = p;
                    while (j > 0)
                    {
                        if (unsortedDraw[j - 1] > unsortedDraw[j])
                        {
                            int temp = unsortedDraw[j - 1]; // Insertion Sort on the array of unsorted numbers.
                            unsortedDraw[j - 1] = unsortedDraw[j];
                            unsortedDraw[j] = temp;
                        }
                        j = j - 1;
                    }
                }

                int k;
                k = 0; // k is acting as a pointer here, therefore has to be initialised as 0.

                for (int i = 2; i < 7; i++)
                {
                    lottoDatabaseDataSet1.draws.Rows[0][i] = unsortedDraw[k]; // Inserting the sorted array back into the data set.
                    k++;
                }

                drawsTableAdapter1.Update(lottoDatabaseDataSet1.draws);
                // drawsTableAdapter1.finishedDraw(latestDraw); // Marks the latest draw as finished.
            }
        }

        private void refreshTmr_Tick(object sender, EventArgs e)
        {
            drawsTableAdapter1.getLatestDraw(lottoDatabaseDataSet1.draws);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            adminPanel adminForm = new adminPanel();
            adminForm.Show();
            this.Hide();
        }
    }
}
