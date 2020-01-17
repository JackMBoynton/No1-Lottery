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
    public partial class checkTicketsForm : MetroFramework.Forms.MetroForm
    {
        public checkTicketsForm()
        {
            InitializeComponent();
        }

        int drawCode;
        int ticketID;
        int tickUsrID;

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {

            // Inserting the latest draw into an array to cross check the draws.
            int[] latestDraw = new int[5];

            for (int i = 2; i < 7; i++)
            {
                latestDraw[i - 2] = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[0][i]);
            }


            // Loading the ticketArray with the tickets bought and 5 numbers from each.
            int rowCount = lottoDatabaseDataSet1.tickets.Rows.Count;
            int[] ticketArray = new int[5];

            for (int j = 0; j < rowCount; j++) // Each ticket is being checked.
            {
                for (int i = 2; i < 7; i++)
                {
                    ticketArray[i-2] = Convert.ToInt32(lottoDatabaseDataSet1.tickets.Rows[j][i]);
                }

                // Checking each ticket against the latest Draw and telling the user the numbers they got correct as well as how many numbers they succeeded in out of 5.
                int matchCount = 0;

                for (int i = 0; i < 5; i++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        if (ticketArray[x] == latestDraw[i])
                        {
                            // Increment correct numbers variable by one if a match is found.
                            matchCount++;
                        }
                    }
                }

                // Each ticket is being checked here, therefore, we want to input the winning tickets into a winning table / non winning table.

                drawCode = Convert.ToInt32(lottoDatabaseDataSet1.tickets.Rows[j][1]);
                ticketID = Convert.ToInt32(lottoDatabaseDataSet1.tickets.Rows[j][7]);
                tickUsrID = Convert.ToInt32(lottoDatabaseDataSet1.tickets.Rows[j][0]);


                 if (matchCount == 5)
                 {
                     decimal prizeWon;
                     prizeWon = Convert.ToDecimal(((lottoDatabaseDataSet1.tickets.Rows.Count) * 2) * 0.75);
                     Math.Round(prizeWon, 0); // Round the decimal to a round whole number, user has won the jackpot.
                     winnersTableAdapter1.Insert(drawCode, ticketID, tickUsrID, Convert.ToInt32(prizeWon));
                 }
                 else if (matchCount == 4)
                 {
                     int prizeWon;
                     prizeWon = 500; // 4 numbers awards the user £500 as standard.
                     winnersTableAdapter1.Insert(drawCode, ticketID, tickUsrID, prizeWon);
                 }
                 else if (matchCount == 3)
                 {
                     int prizeWon;
                     prizeWon = 2; // 3 Numbers is a free ticket for the user, equal to £2.
                     winnersTableAdapter1.Insert(drawCode, ticketID, tickUsrID, prizeWon);
                 }
                 else 
                 {
                     int prizeWon;
                     prizeWon = 0; // User lost - no prize.
                     nonWinnersTableAdapter1.Insert(drawCode, ticketID, tickUsrID, prizeWon);
                 }
                 
            }

            winnersTableAdapter1.Fill(lottoDatabaseDataSet1.winners);
            int winnersCount; // Filling the winners adapter before getting the exact winners count.
            winnersCount = Convert.ToInt32(lottoDatabaseDataSet1.winners.Rows.Count);

            nonWinnersTableAdapter1.Fill(lottoDatabaseDataSet1.nonWinners);
            int nonWinnersCount; // Filling the nonWinners adapter before getting the exact nonWinners count.
            nonWinnersCount = Convert.ToInt32(lottoDatabaseDataSet1.nonWinners.Rows.Count);

            for (int k = 0; k < winnersCount; k++) // For every ticket that won - Update their balance with the amount won.
            {
                int winTcktID;
                winTcktID = Convert.ToInt32(lottoDatabaseDataSet1.winners.Rows[k][2]);
                int prizeWon;
                prizeWon = Convert.ToInt32(lottoDatabaseDataSet1.winners.Rows[k][4]); // The prize won for each ticket.
                int usrID;
                usrID = Convert.ToInt32(lottoDatabaseDataSet1.winners.Rows[k][3]); // The User ID for each ticket.
                usersTableAdapter1.topUpBal(prizeWon, usrID); // Updating the user balance by the prize that the user won, via their user ID.
                usrMsgsTableAdapter1.Insert(usrID, "Winner!", "Congratulations, with the ticket: " + winTcktID + " on Draw: " + drawCode + ", you have won: £" + prizeWon + " this amount has been credited to your account balance.");
            }

            for (int i = 0; i < nonWinnersCount; i++)
            {
                int nonWinTcktID;
                nonWinTcktID = Convert.ToInt32(lottoDatabaseDataSet1.nonWinners.Rows[i][2]);
                int prizeWon;
                prizeWon = Convert.ToInt32(lottoDatabaseDataSet1.nonWinners.Rows[i][4]); // The prize won for each ticket.
                int usrID;
                usrID = Convert.ToInt32(lottoDatabaseDataSet1.nonWinners.Rows[i][3]); // The User ID for each ticket.
                usrMsgsTableAdapter1.Insert(usrID, "Non-Winner.", "Sorry you have not won, with the ticket: " + nonWinTcktID + " on Draw: " + drawCode + " No money has been credited to your account, thank you for playing No.1 Lotto");
            }

            ticketsTableAdapter1.readyForNewDraw();
            winnersTableAdapter1.readyForNewDraw();
            nonWinnersTableAdapter1.readyForNewDraw();

        }

        private void refreshTmr_Tick(object sender, EventArgs e)
        {
            ticketsTableAdapter1.Fill(lottoDatabaseDataSet1.tickets);
            drawsTableAdapter1.Fill(lottoDatabaseDataSet1.draws);
            winnersTableAdapter1.Fill(lottoDatabaseDataSet1.winners);
            nonWinnersTableAdapter1.Fill(lottoDatabaseDataSet1.nonWinners);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            adminPanel adminForm = new adminPanel();
            adminForm.Show();
            this.Hide();
        }
    }
}
