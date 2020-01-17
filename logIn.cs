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
    public partial class logIn : MetroFramework.Forms.MetroForm
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            signUpForm signUp = new signUpForm();
            signUp.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.tryKey(lottoDatabaseDataSet1.users, userBox.Text, passBox.Text); // Links Data Set and 2 Text Boxes to Table Adapter.
            if (lottoDatabaseDataSet1.users.Rows.Count == 1)
            {
                usersTableAdapter1.AccountDataReturn(lottoDatabaseDataSet1.users, userBox.Text);
                // Assigns data to global user.
                Variables.thisUserID = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][0].ToString());
                Variables.thisUserUsername = lottoDatabaseDataSet1.users.Rows[0][1].ToString();
                //Assigning the original balance, opening balance.
                Variables.thisUserBal = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][7].ToString());
                //Assigning the DOB
                Variables.thisUserDOB = lottoDatabaseDataSet1.users.Rows[0][6].ToString();
                //Assigning the Email
                Variables.thisUserEmail = lottoDatabaseDataSet1.users.Rows[0][3].ToString();
                //Assigning the First Name
                Variables.thisUserFirstName = lottoDatabaseDataSet1.users.Rows[0][4].ToString();
                //Assigning the Last Name
                Variables.thisUserLastName = lottoDatabaseDataSet1.users.Rows[0][5].ToString();
                //Assigning the Age of the User
                Variables.thisUserAge = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][8]);
                //Assigning the users betting limit / deposit limit.
                if (lottoDatabaseDataSet1.users.Rows[0][9].ToString() == "")
                {

                } else
                {
                    Variables.thisUserAccLimit = Convert.ToInt32(lottoDatabaseDataSet1.users.Rows[0][9].ToString());
                }
                //Assigning the users Admin capabilities.
                Variables.thisUserAdmin = Convert.ToBoolean(lottoDatabaseDataSet1.users.Rows[0][10]);
                Variables.loggedOut = false;

                mainMenu mainMenu = new mainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
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
