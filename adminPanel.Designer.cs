namespace LotteryApplication
{
    partial class adminPanel
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
            this.ticketsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.ticketsTableAdapter();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.winnersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.winnersTableAdapter();
            this.nonWinnersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.nonWinnersTableAdapter();
            this.usrMsgsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.refreshTmr = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allocationBtn = new MetroFramework.Controls.MetroButton();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.drawsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.deleteUsrBtn = new MetroFramework.Controls.MetroButton();
            this.userSelectCmbo = new MetroFramework.Controls.MetroComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewPplBtn = new MetroFramework.Controls.MetroButton();
            this.viewFundsBtn = new MetroFramework.Controls.MetroButton();
            this.viewSoldBtn = new MetroFramework.Controls.MetroButton();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsTableAdapter1
            // 
            this.ticketsTableAdapter1.ClearBeforeFill = true;
            // 
            // lottoDatabaseDataSet1
            // 
            this.lottoDatabaseDataSet1.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drawsTableAdapter1
            // 
            this.drawsTableAdapter1.ClearBeforeFill = true;
            // 
            // winnersTableAdapter1
            // 
            this.winnersTableAdapter1.ClearBeforeFill = true;
            // 
            // nonWinnersTableAdapter1
            // 
            this.nonWinnersTableAdapter1.ClearBeforeFill = true;
            // 
            // usrMsgsTableAdapter1
            // 
            this.usrMsgsTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // refreshTmr
            // 
            this.refreshTmr.Enabled = true;
            this.refreshTmr.Tick += new System.EventHandler(this.refreshTmr_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allocationBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Options";
            // 
            // allocationBtn
            // 
            this.allocationBtn.Highlight = true;
            this.allocationBtn.Location = new System.Drawing.Point(393, 28);
            this.allocationBtn.Name = "allocationBtn";
            this.allocationBtn.Size = new System.Drawing.Size(376, 43);
            this.allocationBtn.TabIndex = 3;
            this.allocationBtn.Text = "Check Tickets and Allocate the Prizes";
            this.allocationBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.allocationBtn.Click += new System.EventHandler(this.allocationBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Highlight = true;
            this.startBtn.Location = new System.Drawing.Point(11, 28);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(376, 43);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Draw";
            this.startBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // drawsBindingSource
            // 
            this.drawsBindingSource.DataMember = "draws";
            this.drawsBindingSource.DataSource = this.lottoDatabaseDataSet1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.deleteUsrBtn);
            this.groupBox2.Controls.Add(this.userSelectCmbo);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Options";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(350, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Select a User:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // deleteUsrBtn
            // 
            this.deleteUsrBtn.Highlight = true;
            this.deleteUsrBtn.Location = new System.Drawing.Point(265, 83);
            this.deleteUsrBtn.Name = "deleteUsrBtn";
            this.deleteUsrBtn.Size = new System.Drawing.Size(250, 43);
            this.deleteUsrBtn.TabIndex = 3;
            this.deleteUsrBtn.Text = "Delete User";
            this.deleteUsrBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteUsrBtn.Click += new System.EventHandler(this.deleteUsrBtn_Click);
            // 
            // userSelectCmbo
            // 
            this.userSelectCmbo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Username", true));
            this.userSelectCmbo.DataSource = this.usersBindingSource;
            this.userSelectCmbo.DisplayMember = "Username";
            this.userSelectCmbo.FormattingEnabled = true;
            this.userSelectCmbo.ItemHeight = 23;
            this.userSelectCmbo.Location = new System.Drawing.Point(265, 42);
            this.userSelectCmbo.Name = "userSelectCmbo";
            this.userSelectCmbo.Size = new System.Drawing.Size(250, 29);
            this.userSelectCmbo.Style = MetroFramework.MetroColorStyle.Blue;
            this.userSelectCmbo.TabIndex = 1;
            this.userSelectCmbo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userSelectCmbo.ValueMember = "Username";
            this.userSelectCmbo.SelectedIndexChanged += new System.EventHandler(this.userSelectCmbo_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.lottoDatabaseDataSet1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewPplBtn);
            this.groupBox3.Controls.Add(this.viewFundsBtn);
            this.groupBox3.Controls.Add(this.viewSoldBtn);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(23, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // viewPplBtn
            // 
            this.viewPplBtn.Highlight = true;
            this.viewPplBtn.Location = new System.Drawing.Point(521, 26);
            this.viewPplBtn.Name = "viewPplBtn";
            this.viewPplBtn.Size = new System.Drawing.Size(248, 43);
            this.viewPplBtn.TabIndex = 3;
            this.viewPplBtn.Text = "View People Playing No. 1 Lotto";
            this.viewPplBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.viewPplBtn.Click += new System.EventHandler(this.viewPplBtn_Click);
            // 
            // viewFundsBtn
            // 
            this.viewFundsBtn.Highlight = true;
            this.viewFundsBtn.Location = new System.Drawing.Point(265, 26);
            this.viewFundsBtn.Name = "viewFundsBtn";
            this.viewFundsBtn.Size = new System.Drawing.Size(250, 43);
            this.viewFundsBtn.TabIndex = 2;
            this.viewFundsBtn.Text = "View Funds Generated";
            this.viewFundsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.viewFundsBtn.Click += new System.EventHandler(this.viewFundsBtn_Click);
            // 
            // viewSoldBtn
            // 
            this.viewSoldBtn.Highlight = true;
            this.viewSoldBtn.Location = new System.Drawing.Point(11, 26);
            this.viewSoldBtn.Name = "viewSoldBtn";
            this.viewSoldBtn.Size = new System.Drawing.Size(248, 43);
            this.viewSoldBtn.TabIndex = 0;
            this.viewSoldBtn.Text = "View Amount of Tickets Sold";
            this.viewSoldBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.viewSoldBtn.Click += new System.EventHandler(this.viewSoldBtn_Click);
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 25);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 8;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 409);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.adminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lottoDatabaseDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.winnersTableAdapter winnersTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.nonWinnersTableAdapter nonWinnersTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter usrMsgsTableAdapter1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Timer refreshTmr;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton allocationBtn;
        private System.Windows.Forms.BindingSource drawsBindingSource;
        private MetroFramework.Controls.MetroButton startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton deleteUsrBtn;
        private MetroFramework.Controls.MetroComboBox userSelectCmbo;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton viewPplBtn;
        private MetroFramework.Controls.MetroButton viewFundsBtn;
        private MetroFramework.Controls.MetroButton viewSoldBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}