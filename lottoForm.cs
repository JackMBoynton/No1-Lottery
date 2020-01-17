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
    public partial class lottoForm : MetroFramework.Forms.MetroForm
    {

        public lottoForm()
        {
            InitializeComponent();
        }

        private void lottoForm_Load(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            lottoNumberPick lottoPick = new lottoNumberPick();
            lottoPick.Show();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            drawsTableAdapter1.returnPastDraws(lottoDatabaseDataSet1.draws);

            int dCount;
            dCount = lottoDatabaseDataSet1.draws.Rows.Count - 1;

            int num1 = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[dCount][2]);
            int num2 = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[dCount][3]);
            int num3 = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[dCount][4]);
            int num4 = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[dCount][5]);
            int num5 = Convert.ToInt32(lottoDatabaseDataSet1.draws.Rows[dCount][6]);

            MessageBox.Show("Latest numbers drawn were as follows: " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5, "LATEST NUMBERS DRAWN");
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
