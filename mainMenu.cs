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
    public partial class mainMenu : MetroFramework.Forms.MetroForm
    {

        double Jackpot;

        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            drawsTableAdapter1.getLatestDraw(lottoDatabaseDataSet1.draws);

            DateTime todaysDate = System.DateTime.Now.Date;
            DateTime latestDraw = Convert.ToDateTime(lottoDatabaseDataSet1.draws.Rows[0][1]).Date;
            bool drawDone = Convert.ToBoolean(lottoDatabaseDataSet1.draws.Rows[0][7]);

            userLbl.Text = Variables.thisUserUsername.ToString();
            // Showing the original opening balance of user.
            userBalLbl.Text = "£" + Variables.thisUserBal.ToString();
            // Checking for admin.
            if (Variables.thisUserAdmin == true)
            {
                adminPnlBtn.Visible = true;
                if (drawDone != true)
                {
                    if (todaysDate == latestDraw)
                    {
                        MessageBox.Show("Today is the date the draw is due, please draw the numbers and allocate tickets");
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {
                adminPnlBtn.Visible = false;
            }             
        }

        private void lottoTile_Click(object sender, EventArgs e)
        {
            var lottoForm = new lottoForm();
            var currentForm = new mainMenu();

            lottoForm.Show();
            currentForm.Close();
        }

        private void userLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutTile_Click(object sender, EventArgs e)
        {
            Variables.loggedOut = true;

            logIn logIn = new logIn();
            logIn.Show();
            this.Hide();
            Variables.thisUserAccLimit = Convert.ToInt32("0");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // As the timer ticks, the querey is executed again, updating the balance.
            usersTableAdapter1.AccountDataReturn(lottoDatabaseDataSet1.users, Variables.thisUserUsername);
            Variables.thisUserBal = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][7]);
            userBalLbl.Text = "£" + Variables.thisUserBal.ToString();

            // Fill the tickets table for row count, every second in case another ticket has just been bought.
            ticketsTableAdapter1.Fill(lottoDatabaseDataSet1.tickets);

            // Checking for admin.
            if (Variables.thisUserAdmin == true)
            {
                adminPnlBtn.Visible = true;
            }
            else
            {
                adminPnlBtn.Visible = false;
            }

            // As the timer ticks, the jackpot is updated, depending on the amount of tickets sold.
            Jackpot = (lottoDatabaseDataSet1.tickets.Rows.Count * 2) * 0.75;

        }

        private void bankTile_Click(object sender, EventArgs e)
        {
            bankForm bankForm = new bankForm();
            bankForm.Show();
            this.Hide();
        }

        private void accTile_Click(object sender, EventArgs e)
        {
            accInformation accForm = new accInformation();
            accForm.Show();
            this.Hide();
        }

        private void adminPnlBtn_Click(object sender, EventArgs e)
        {
            adminPanel adminForm = new adminPanel();
            adminForm.Show();
            this.Close();
        }

        private void prizeTile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 Numbers: £2 (Free Ticket for Next Draw)" + Environment.NewLine + "4 Numbers: £500" + Environment.NewLine + "5 Numbers: Jackpot (Currently for this Draw: £" + Jackpot + ")");
        }

        private void msgsTile_Click(object sender, EventArgs e)
        {
            msgsForm messagesForm = new msgsForm();
            messagesForm.Show();
        }

        private void drawsTile_Click(object sender, EventArgs e)
        {
            pastDrawsForm pDrawsForm = new pastDrawsForm();
            pDrawsForm.Show();
        }
    }
}
