namespace LotteryApplication
{
    partial class checkTicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.ticketsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.ticketsTableAdapter();
            this.drawBtn = new MetroFramework.Controls.MetroButton();
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.winnersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.winnersTableAdapter();
            this.refreshTmr = new System.Windows.Forms.Timer(this.components);
            this.nonWinnersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.nonWinnersTableAdapter();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.usrMsgsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lottoDatabaseDataSet1
            // 
            this.lottoDatabaseDataSet1.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter1
            // 
            this.ticketsTableAdapter1.ClearBeforeFill = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Highlight = true;
            this.drawBtn.Location = new System.Drawing.Point(152, 77);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(142, 45);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Check Tickets";
            this.drawBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // drawsTableAdapter1
            // 
            this.drawsTableAdapter1.ClearBeforeFill = true;
            // 
            // winnersTableAdapter1
            // 
            this.winnersTableAdapter1.ClearBeforeFill = true;
            // 
            // refreshTmr
            // 
            this.refreshTmr.Enabled = true;
            this.refreshTmr.Tick += new System.EventHandler(this.refreshTmr_Tick);
            // 
            // nonWinnersTableAdapter1
            // 
            this.nonWinnersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usrMsgsTableAdapter1
            // 
            this.usrMsgsTableAdapter1.ClearBeforeFill = true;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 24);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 8;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // checkTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 173);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.drawBtn);
            this.Name = "checkTicketsForm";
            this.Text = "Check the User\'s Tickets";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter1;
        private MetroFramework.Controls.MetroButton drawBtn;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.winnersTableAdapter winnersTableAdapter1;
        private System.Windows.Forms.Timer refreshTmr;
        private lottoDatabaseDataSetTableAdapters.nonWinnersTableAdapter nonWinnersTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter usrMsgsTableAdapter1;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}