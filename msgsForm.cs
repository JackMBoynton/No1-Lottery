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
    public partial class msgsForm : MetroFramework.Forms.MetroForm
    {
        public msgsForm()
        {
            InitializeComponent();
        }

        private void msgsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lottoDatabaseDataSet.usrMsgs' table. You can move, or remove it, as needed.
            this.usrMsgsTableAdapter.filterByUserID(this.lottoDatabaseDataSet.usrMsgs, Variables.thisUserID);

            usrMsgsDGV.Columns[0].Width = 50;
            usrMsgsDGV.Columns[1].Width = 35;
            usrMsgsDGV.Columns[2].Width = 75;
            usrMsgsDGV.Columns[3].Width = 850;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
