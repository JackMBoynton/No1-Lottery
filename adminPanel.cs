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
    public partial class adminPanel : MetroFramework.Forms.MetroForm
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            usersTableAdapter1.Fill(lottoDatabaseDataSet1.users);
            drawsTableAdapter1.getLatestDraw(lottoDatabaseDataSet1.draws);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            DateTime todaysDate = System.DateTime.Now.Date;
            DateTime latestDraw = Convert.ToDateTime(lottoDatabaseDataSet1.draws.Rows[0][1]).Date;

            if (todaysDate != latestDraw)
            {
                MessageBox.Show("Draw is not ready to be done yet.");
            } else
            {
                drawAdminForm drawForm = new drawAdminForm();
                drawForm.Show();
                this.Hide();
            }

            
            
        }

        private void refreshTmr_Tick(object sender, EventArgs e)
        {
            usrMsgsTableAdapter1.Fill(lottoDatabaseDataSet1.usrMsgs);
            ticketsTableAdapter1.Fill(lottoDatabaseDataSet1.tickets);
        }

        private void allocationBtn_Click(object sender, EventArgs e)
        {
            checkTicketsForm checkForm = new checkTicketsForm();
            checkForm.Show();
            this.Hide();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void viewSoldBtn_Click(object sender, EventArgs e)
        {
            int pastTicketsCount;
            pastTicketsCount = lottoDatabaseDataSet1.usrMsgs.Rows.Count;
            int latestDrawTickets;
            latestDrawTickets = lottoDatabaseDataSet1.tickets.Rows.Count;
            int ticketsSold;
            ticketsSold = pastTicketsCount + latestDrawTickets;
            MessageBox.Show("Amount of Tickets Sold: " + ticketsSold);
        }

        private void viewFundsBtn_Click(object sender, EventArgs e)
        {
            int pastTicketsCount;
            pastTicketsCount = lottoDatabaseDataSet1.usrMsgs.Rows.Count;
            int latestDrawTickets;
            latestDrawTickets = lottoDatabaseDataSet1.tickets.Rows.Count;
            int ticketsSold;
            ticketsSold = pastTicketsCount + latestDrawTickets;
            int funds;
            funds = ticketsSold * 2;
            MessageBox.Show("Funds Generated in Total: £" + (funds) + Environment.NewLine + "Funds for Paying Out: £" + (funds * 0.75) + Environment.NewLine + "Funds for Good Causes: £" + (funds * 0.25));
        }

        private void viewPplBtn_Click(object sender, EventArgs e)
        {
            int usersSignedUp;
            usersSignedUp = lottoDatabaseDataSet1.users.Rows.Count;
            MessageBox.Show("Users Signed Up: " + usersSignedUp);
        }

        private void deleteUsrBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(userSelectCmbo.SelectedValue) == "boyntonj")
            {
                MessageBox.Show("Cannot delete this user, as they are main admin.");
            } else { 
            usersTableAdapter1.deleteUser(Convert.ToString(userSelectCmbo.SelectedValue));
            }
        }

        private void userSelectCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
