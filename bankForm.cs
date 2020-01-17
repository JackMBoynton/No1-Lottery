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
    public partial class bankForm : MetroFramework.Forms.MetroForm
    {
        public bankForm()
        {
            InitializeComponent();
        }

        bool AccLimit;

        private void bankForm_Load(object sender, EventArgs e)
        {
            depositPnl.Visible = false;
            withdrawPnl.Visible = false;
            depositLmt.Visible = false;
            depositLmtBtn.Visible = false;

            // All Panels
            curBalLbl.Text = Variables.thisUserBal.ToString();
            curBalLbl2.Text = Variables.thisUserBal.ToString();

        }

        private void panelSlctCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelSlctCmboBox.SelectedItem.ToString() == "Deposit")
            {
                depositPnl.Visible = true;
                withdrawPnl.Visible = false;

            }
            else if (panelSlctCmboBox.SelectedItem.ToString() == "Withdrawal")
            {
                depositPnl.Visible = false;
                withdrawPnl.Visible = true;
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usersTableAdapter1.AccountDataReturn(lottoDatabaseDataSet1.users, Variables.thisUserUsername);
            Variables.thisUserBal = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][7]);
            curBalLbl.Text = "£" + Variables.thisUserBal.ToString();
            if (lottoDatabaseDataSet1.users.Rows[0][9].ToString() == "")
            {
                AccLimit = false;
            }
            else
            {
                Variables.thisUserAccLimit = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][9]);
            }
            curBalLbl2.Text = "£" + Variables.thisUserBal.ToString();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (amountBox.Text.Contains("-"))
            {
                MessageBox.Show("You cannot deposit a minus amount. Please try again.");
            } else try
            {
                if (AccLimit == false)
                {
                    usersTableAdapter1.topUpBal(Convert.ToInt32(amountBox.Text), Variables.thisUserID);
                    amountBox.Text = "";
                }
                else if (Convert.ToInt32(amountBox.Text) > Variables.thisUserAccLimit)
                {
                    MessageBox.Show("You are trying to deposit an amount which is over the limit your account can deposit. To change this, please update your account limit using the link below");
                }
            }
            catch (Exception error)
            {
                if (error.ToString().Contains("Input string was not in a correct format"))
                {
                    MessageBox.Show("Please enter a deposit value that is correct and is integer only.");
                    amountBox.Text = "";
                }
            }
        }

        private void depositLmtLbl_Click(object sender, EventArgs e)
        {
            depositLmt.Visible = true;
            depositLmtBtn.Visible = true;
        }

        private void depositLmtBtn_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.updateAccLimit(Convert.ToInt32(depositLmt.Text), Variables.thisUserID);
            depositLmtBtn.Visible = false;
            depositLmt.Visible = false;
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (withdrawAmnt.Text.Contains("-"))
            {
                MessageBox.Show("You cannot withdraw a minus amount. Please try again.");
            }
            else try
            {
                if (Convert.ToInt32(withdrawAmnt.Text) > Variables.thisUserBal)
                {
                    MessageBox.Show("Sorry, you cannot withdraw more than is in your account.");
                    withdrawAmnt.Text = "";
                }
                else
                {
                    usersTableAdapter1.withdrawBal(Convert.ToInt32(withdrawAmnt.Text), Variables.thisUserID);
                    withdrawAmnt.Text = "";
                }
            }
            catch (Exception error)
            {
                if (error.ToString().Contains("Input string was not in a correct format"))
                {
                    MessageBox.Show("Please enter a withdrawal value that is correct and is integer only.");
                    withdrawAmnt.Text = "";
                }
            }   
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            mainMenu menuForm = new mainMenu();
            menuForm.Show();
            this.Close();
        }

    }
}
