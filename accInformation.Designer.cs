namespace LotteryApplication
{
    partial class accInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accInformation));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accIDLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.accBalLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.accUsernameLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.accEmailLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.accFNLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.accLNLbl = new MetroFramework.Controls.MetroLabel();
            this.accDOBLbl = new MetroFramework.Controls.MetroLabel();
            this.accAgeLbl = new MetroFramework.Controls.MetroLabel();
            this.accDepLmtLbl = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(229, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Account ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(220, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(190, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Account Information";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // accIDLbl
            // 
            this.accIDLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accIDLbl.AutoSize = true;
            this.accIDLbl.Location = new System.Drawing.Point(315, 147);
            this.accIDLbl.Name = "accIDLbl";
            this.accIDLbl.Size = new System.Drawing.Size(131, 19);
            this.accIDLbl.TabIndex = 18;
            this.accIDLbl.Text = "Debugging Purposes";
            this.accIDLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.accIDLbl.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(217, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "User Balance:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accBalLbl
            // 
            this.accBalLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accBalLbl.AutoSize = true;
            this.accBalLbl.Location = new System.Drawing.Point(315, 175);
            this.accBalLbl.Name = "accBalLbl";
            this.accBalLbl.Size = new System.Drawing.Size(131, 19);
            this.accBalLbl.TabIndex = 20;
            this.accBalLbl.Text = "Debugging Purposes";
            this.accBalLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(233, 203);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Username:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accUsernameLbl
            // 
            this.accUsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accUsernameLbl.AutoSize = true;
            this.accUsernameLbl.Location = new System.Drawing.Point(315, 203);
            this.accUsernameLbl.Name = "accUsernameLbl";
            this.accUsernameLbl.Size = new System.Drawing.Size(131, 19);
            this.accUsernameLbl.TabIndex = 22;
            this.accUsernameLbl.Text = "Debugging Purposes";
            this.accUsernameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(228, 259);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "First Name:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accEmailLbl
            // 
            this.accEmailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accEmailLbl.AutoSize = true;
            this.accEmailLbl.Location = new System.Drawing.Point(315, 231);
            this.accEmailLbl.Name = "accEmailLbl";
            this.accEmailLbl.Size = new System.Drawing.Size(131, 19);
            this.accEmailLbl.TabIndex = 24;
            this.accEmailLbl.Text = "Debugging Purposes";
            this.accEmailLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(260, 231);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(44, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Email:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accFNLbl
            // 
            this.accFNLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accFNLbl.AutoSize = true;
            this.accFNLbl.Location = new System.Drawing.Point(315, 259);
            this.accFNLbl.Name = "accFNLbl";
            this.accFNLbl.Size = new System.Drawing.Size(131, 19);
            this.accFNLbl.TabIndex = 26;
            this.accFNLbl.Text = "Debugging Purposes";
            this.accFNLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(230, 287);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(74, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Last Name:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(217, 315);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(87, 19);
            this.metroLabel13.TabIndex = 28;
            this.metroLabel13.Text = "Date of Birth:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(268, 343);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(36, 19);
            this.metroLabel14.TabIndex = 29;
            this.metroLabel14.Text = "Age:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(165, 371);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(139, 19);
            this.metroLabel15.TabIndex = 30;
            this.metroLabel15.Text = "Account Deposit Limit:";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accLNLbl
            // 
            this.accLNLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accLNLbl.AutoSize = true;
            this.accLNLbl.Location = new System.Drawing.Point(315, 287);
            this.accLNLbl.Name = "accLNLbl";
            this.accLNLbl.Size = new System.Drawing.Size(131, 19);
            this.accLNLbl.TabIndex = 31;
            this.accLNLbl.Text = "Debugging Purposes";
            this.accLNLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accDOBLbl
            // 
            this.accDOBLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accDOBLbl.AutoSize = true;
            this.accDOBLbl.Location = new System.Drawing.Point(315, 315);
            this.accDOBLbl.Name = "accDOBLbl";
            this.accDOBLbl.Size = new System.Drawing.Size(131, 19);
            this.accDOBLbl.TabIndex = 32;
            this.accDOBLbl.Text = "Debugging Purposes";
            this.accDOBLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accAgeLbl
            // 
            this.accAgeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accAgeLbl.AutoSize = true;
            this.accAgeLbl.Location = new System.Drawing.Point(315, 343);
            this.accAgeLbl.Name = "accAgeLbl";
            this.accAgeLbl.Size = new System.Drawing.Size(131, 19);
            this.accAgeLbl.TabIndex = 33;
            this.accAgeLbl.Text = "Debugging Purposes";
            this.accAgeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // accDepLmtLbl
            // 
            this.accDepLmtLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accDepLmtLbl.AutoSize = true;
            this.accDepLmtLbl.Location = new System.Drawing.Point(315, 371);
            this.accDepLmtLbl.Name = "accDepLmtLbl";
            this.accDepLmtLbl.Size = new System.Drawing.Size(131, 19);
            this.accDepLmtLbl.TabIndex = 34;
            this.accDepLmtLbl.Text = "Debugging Purposes";
            this.accDepLmtLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // lottoDatabaseDataSet1
            // 
            this.lottoDatabaseDataSet1.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(385, 315);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "               ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(39, 60);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 7;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // accInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.accDepLmtLbl);
            this.Controls.Add(this.accAgeLbl);
            this.Controls.Add(this.accDOBLbl);
            this.Controls.Add(this.accLNLbl);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.accFNLbl);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.accEmailLbl);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.accUsernameLbl);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.accBalLbl);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.accIDLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.backLbl);
            this.Name = "accInformation";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.accInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel accIDLbl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel accBalLbl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel accUsernameLbl;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel accEmailLbl;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel accFNLbl;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel accLNLbl;
        private MetroFramework.Controls.MetroLabel accDOBLbl;
        private MetroFramework.Controls.MetroLabel accAgeLbl;
        private MetroFramework.Controls.MetroLabel accDepLmtLbl;
        private System.Windows.Forms.Timer timer1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}