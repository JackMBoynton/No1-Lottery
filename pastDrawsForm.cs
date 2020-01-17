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
    public partial class pastDrawsForm : MetroFramework.Forms.MetroForm
    {
        public pastDrawsForm()
        {
            InitializeComponent();
        }

        private void pastDrawsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lottoDatabaseDataSet.draws' table. You can move, or remove it, as needed.
            this.drawsTableAdapter.returnPastDraws(this.lottoDatabaseDataSet.draws);

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
