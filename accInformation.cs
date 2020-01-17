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
    public partial class accInformation : MetroFramework.Forms.MetroForm
    {
        public accInformation()
        {
            InitializeComponent();
        }

        private void accInformation_Load(object sender, EventArgs e)
        {
            accIDLbl.Text = Variables.thisUserID.ToString();
            accBalLbl.Text = "£" + Variables.thisUserBal.ToString();
            accUsernameLbl.Text = Variables.thisUserUsername;
            accEmailLbl.Text = Variables.thisUserEmail;
            accFNLbl.Text = Variables.thisUserFirstName;
            accLNLbl.Text = Variables.thisUserLastName;
            accDOBLbl.Text = Variables.thisUserDOB;
            accAgeLbl.Text = Variables.thisUserAge.ToString();
            if (Variables.thisUserAccLimit.ToString() == "0")
            {
                accDepLmtLbl.Text = "N/A";
            } else
            {
               accDepLmtLbl.Text = "£" + Variables.thisUserAccLimit.ToString();
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            // Ignore
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usersTableAdapter1.AccountDataReturn(lottoDatabaseDataSet1.users, Variables.thisUserUsername);
            Variables.thisUserBal = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][7]);
            accBalLbl.Text = "£" + Variables.thisUserBal.ToString();
        }          
    }
}
