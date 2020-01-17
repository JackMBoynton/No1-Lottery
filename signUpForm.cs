using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LotteryApplication
{
    public partial class signUpForm : MetroFramework.Forms.MetroForm
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            char[] prohibited = { '!', '"', '£', '$', '%', '^', '&', '*', '(', ')', '{', '}', '[', ']', ':', ';', '@', '#', '~', '<', ',', '>', '.', '?', '/', '¬', '`', '|', ' ' };
            bool userProhibited = userBox.Text.IndexOfAny(prohibited) >= 0;
            bool firstProhibited = firstBox.Text.IndexOfAny(prohibited) >= 0;
            bool lastProhibited = lastBox.Text.IndexOfAny(prohibited) >= 0;

            if ((userBox.Text == "") || (passBox.Text == "") || (emailBox.Text == "") || (firstBox.Text == "") ||
                (lastBox.Text == ""))
            {
                MessageBox.Show("Values for one or more boxes are left blank. This is not allowed, please amend this error and try again.");
            }
            else if (userBox.Text.Length <= 4)
            {
                MessageBox.Show("Please enter a username longer than 4 characters.");
            }
            else if ((userProhibited == true) || (firstProhibited == true) || (lastProhibited == true))
            {
                MessageBox.Show("Either your username, first name or lastname contains characters that are not allowed or a whitespace. Please amend this and try again.");
            }
            else if (!emailBox.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address to proceed, including an @ symbol.");
            }
            else
            {
                //check for existing User
                usersTableAdapter1.Fill(lottoDatabaseDataSet1.users);  //recall the fill query
                int userCount = lottoDatabaseDataSet1.users.Rows.Count;
                bool userExists = false;
                for (int i = 0; i < userCount; i++)
                {

                    if (lottoDatabaseDataSet1.users.Rows[i][1].ToString() == userBox.Text)
                    {
                        userExists = true;
                        break;
                    }
                    else
                    {

                    }
                }
                //outcome
                if (userExists == true)
                {
                    MessageBox.Show("User: " + userBox.Text + " already exists in system! Please proceed to log in.");
                    logIn loginForm = new logIn();
                    this.Close();
                    loginForm.Show();
                }
                else
                {
                    int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dateOfBirth = int.Parse(dobPicker.Value.ToString("yyyyMMdd"));
                    int userAge = (today - dateOfBirth) / 10000;
                    if (userAge < 18)
                    {
                        MessageBox.Show("You are only " + userAge +
                                        " Years Old. Please close the No. 1 Lotto Application. Thank you for your interest, but we only allow 18 or overs to play.");
                    }
                    else
                    {
                        usersTableAdapter1.Insert(userBox.Text, passBox.Text, emailBox.Text, firstBox.Text, lastBox.Text,
                            dobPicker.Value.Date, 0, userAge, 0, false);
                        MessageBox.Show("User created! Please log in using the Login form.");
                        logIn loginForm = new logIn();
                        this.Close();
                        loginForm.Show();
                    }
                }

            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            logIn loginForm = new logIn();
            loginForm.Show();
            this.Close();

        }
    }
}


