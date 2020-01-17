using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryApplication
{
    public partial class lottoNumberPick : MetroFramework.Forms.MetroForm
    {
        public lottoNumberPick()
        {
            InitializeComponent();
        }

        private void lottoDraw_Load(object sender, EventArgs e)
        {
            this.drawsTableAdapter1.fillCmboNonPastDraws(lottoDatabaseDataSet1.draws);
        }

        private void prchseTktBtn_Click(object sender, EventArgs e)
        {
            if (Variables.thisUserBal < 2)
            {
                MessageBox.Show("Not enough funds to purchase a ticket, top up and try again.");
            }
            else
            {
                // Readying Draw Code for Insertion
                int drawCode;
                Int32.TryParse(drawDatesCmboBox.SelectedValue.ToString(), out drawCode);
                // Readying number picks for insertion.
                int num1 = Convert.ToInt32(Math.Round(num1Pick.Value, 0));
                int num2 = Convert.ToInt32(Math.Round(num2Pick.Value, 0));
                int num3 = Convert.ToInt32(Math.Round(num3Pick.Value, 0));
                int num4 = Convert.ToInt32(Math.Round(num4Pick.Value, 0));
                int num5 = Convert.ToInt32(Math.Round(num5Pick.Value, 0));

                if (new int[] {num2, num3, num4, num5}.Contains(num1))
                {
                    MessageBox.Show(
                        "Your tickets contain duplicates, please check and edit the ticket so there are 5 different numbers.");
                }
                else if (new int[] {num1, num3, num4, num5}.Contains(num2))
                {
                    MessageBox.Show(
                        "Your tickets contain duplicates, please check and edit the ticket so there are 5 different numbers.");
                }
                else if (new int[] {num1, num2, num4, num5}.Contains(num3))
                {
                    MessageBox.Show(
                        "Your tickets contain duplicates, please check and edit the ticket so there are 5 different numbers.");
                }
                else if (new int[] {num1, num2, num3, num5}.Contains(num4))
                {
                    MessageBox.Show(
                        "Your tickets contain duplicates, please check and edit the ticket so there are 5 different numbers.");
                }
                else if (new int[] {num1, num2, num3, num4}.Contains(num5))
                {
                    MessageBox.Show(
                        "Your tickets contain duplicates, please check and edit the ticket so there are 5 different numbers.");
                }
                else
                {
                    int[] unsortedDraw = new int[5]; // Creating an array for the sorting to be done on.

                    unsortedDraw[0] = num1;
                    unsortedDraw[1] = num2;
                    unsortedDraw[2] = num3; // Assigning the unsorted values to variables for sorting.
                    unsortedDraw[3] = num4;
                    unsortedDraw[4] = num5;

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

                    num1 = unsortedDraw[0];
                    num2 = unsortedDraw[1];
                    num3 = unsortedDraw[2]; // Assigning the sorted values to variables for inserting into the DB.
                    num4 = unsortedDraw[3];
                    num5 = unsortedDraw[4];

                    // Insert Query for Ticket
                    ticketsTableAdapter1.Insert(Variables.thisUserID, drawCode, num1, num2, num3, num4, num5);
                    // Balance deduction within user account.
                    usersTableAdapter1.decrementBalance(Variables.thisUserID);
                }
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luckyDipBtn_Click(object sender, EventArgs e)
        {
            int[] luckyDip = new int[5];

            int arrayIndex;
            arrayIndex = 0;

            String draw = realtimeDraw.drawNumbers(49, 5) + ","; //draw instance
            int drawLength = draw.Length; //get length of string

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
                    luckyDip[arrayIndex] = Convert.ToInt32(currentBall);
                    currentBall = "";
                    arrayIndex++;
                }
            }

            for (int p = 1; p < 5; p++)
            {
                int j = p;
                while (j > 0)
                {
                    if (luckyDip[j - 1] > luckyDip[j])
                    {
                        int temp = luckyDip[j - 1]; // Insertion Sort on the array of unsorted numbers.
                        luckyDip[j - 1] = luckyDip[j];
                        luckyDip[j] = temp;
                    }
                    j = j - 1;
                }
            }

            int num1 = luckyDip[0];
            int num2 = luckyDip[1];
            int num3 = luckyDip[2];
            int num4 = luckyDip[3];
            int num5 = luckyDip[4];

            num1Pick.Value = num1;
            num2Pick.Value = num2;
            num3Pick.Value = num3;
            num4Pick.Value = num4;
            num5Pick.Value = num5;

        }

        private void fillCmboNonPastDrawsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.drawsTableAdapter1.fillCmboNonPastDraws(this.lottoDatabaseDataSet1.draws);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sessionTimer_Tick(object sender, EventArgs e)
        {
            if (Variables.loggedOut == true)
            {
                this.Close();
            }
        }

        
        }
    }
