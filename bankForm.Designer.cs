namespace LotteryApplication
{
    partial class bankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlctCmboBox = new MetroFramework.Controls.MetroComboBox();
            this.depositPnl = new MetroFramework.Controls.MetroPanel();
            this.depositLmtBtn = new MetroFramework.Controls.MetroButton();
            this.depositLmt = new MetroFramework.Controls.MetroTextBox();
            this.depositLmtLbl = new MetroFramework.Controls.MetroLabel();
            this.depositBtn = new MetroFramework.Controls.MetroButton();
            this.amountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.curBalLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.withdrawPnl = new MetroFramework.Controls.MetroPanel();
            this.withdrawBtn = new MetroFramework.Controls.MetroButton();
            this.withdrawAmnt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.curBalLbl2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.depositPnl.SuspendLayout();
            this.withdrawPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelSlctCmboBox
            // 
            this.panelSlctCmboBox.FormattingEnabled = true;
            this.panelSlctCmboBox.ItemHeight = 23;
            this.panelSlctCmboBox.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal"});
            this.panelSlctCmboBox.Location = new System.Drawing.Point(273, 134);
            this.panelSlctCmboBox.Name = "panelSlctCmboBox";
            this.panelSlctCmboBox.Size = new System.Drawing.Size(272, 29);
            this.panelSlctCmboBox.TabIndex = 3;
            this.panelSlctCmboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSlctCmboBox.SelectedIndexChanged += new System.EventHandler(this.panelSlctCmboBox_SelectedIndexChanged);
            // 
            // depositPnl
            // 
            this.depositPnl.Controls.Add(this.depositLmtBtn);
            this.depositPnl.Controls.Add(this.depositLmt);
            this.depositPnl.Controls.Add(this.depositLmtLbl);
            this.depositPnl.Controls.Add(this.depositBtn);
            this.depositPnl.Controls.Add(this.amountBox);
            this.depositPnl.Controls.Add(this.metroLabel3);
            this.depositPnl.Controls.Add(this.curBalLbl);
            this.depositPnl.Controls.Add(this.metroLabel2);
            this.depositPnl.Controls.Add(this.metroLabel1);
            this.depositPnl.HorizontalScrollbarBarColor = true;
            this.depositPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.depositPnl.HorizontalScrollbarSize = 10;
            this.depositPnl.Location = new System.Drawing.Point(23, 178);
            this.depositPnl.Name = "depositPnl";
            this.depositPnl.Size = new System.Drawing.Size(743, 330);
            this.depositPnl.TabIndex = 4;
            this.depositPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.depositPnl.VerticalScrollbarBarColor = true;
            this.depositPnl.VerticalScrollbarHighlightOnWheel = false;
            this.depositPnl.VerticalScrollbarSize = 10;
            // 
            // depositLmtBtn
            // 
            this.depositLmtBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositLmtBtn.Highlight = true;
            this.depositLmtBtn.Location = new System.Drawing.Point(311, 212);
            this.depositLmtBtn.Name = "depositLmtBtn";
            this.depositLmtBtn.Size = new System.Drawing.Size(118, 23);
            this.depositLmtBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.depositLmtBtn.TabIndex = 16;
            this.depositLmtBtn.Text = "Set Limit";
            this.depositLmtBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.depositLmtBtn.Click += new System.EventHandler(this.depositLmtBtn_Click);
            // 
            // depositLmt
            // 
            this.depositLmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositLmt.Location = new System.Drawing.Point(311, 186);
            this.depositLmt.Name = "depositLmt";
            this.depositLmt.PromptText = "Amount";
            this.depositLmt.Size = new System.Drawing.Size(118, 23);
            this.depositLmt.TabIndex = 15;
            this.depositLmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depositLmt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // depositLmtLbl
            // 
            this.depositLmtLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositLmtLbl.AutoSize = true;
            this.depositLmtLbl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.depositLmtLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositLmtLbl.Location = new System.Drawing.Point(316, 164);
            this.depositLmtLbl.Name = "depositLmtLbl";
            this.depositLmtLbl.Size = new System.Drawing.Size(107, 19);
            this.depositLmtLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.depositLmtLbl.TabIndex = 14;
            this.depositLmtLbl.Text = "Set Deposit Limit";
            this.depositLmtLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.depositLmtLbl.UseStyleColors = true;
            this.depositLmtLbl.Click += new System.EventHandler(this.depositLmtLbl_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositBtn.Highlight = true;
            this.depositBtn.Location = new System.Drawing.Point(424, 129);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(89, 23);
            this.depositBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.depositBtn.TabIndex = 10;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // amountBox
            // 
            this.amountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountBox.Location = new System.Drawing.Point(344, 129);
            this.amountBox.Name = "amountBox";
            this.amountBox.PromptText = "Amount";
            this.amountBox.Size = new System.Drawing.Size(74, 23);
            this.amountBox.TabIndex = 6;
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Deposit New Amount:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // curBalLbl
            // 
            this.curBalLbl.AutoSize = true;
            this.curBalLbl.Location = new System.Drawing.Point(344, 94);
            this.curBalLbl.Name = "curBalLbl";
            this.curBalLbl.Size = new System.Drawing.Size(74, 19);
            this.curBalLbl.TabIndex = 4;
            this.curBalLbl.Text = "Debugging";
            this.curBalLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.curBalLbl.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(233, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Current Balance:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(332, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Deposit";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // withdrawPnl
            // 
            this.withdrawPnl.Controls.Add(this.withdrawBtn);
            this.withdrawPnl.Controls.Add(this.withdrawAmnt);
            this.withdrawPnl.Controls.Add(this.metroLabel5);
            this.withdrawPnl.Controls.Add(this.curBalLbl2);
            this.withdrawPnl.Controls.Add(this.metroLabel7);
            this.withdrawPnl.Controls.Add(this.metroLabel8);
            this.withdrawPnl.HorizontalScrollbarBarColor = true;
            this.withdrawPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.withdrawPnl.HorizontalScrollbarSize = 10;
            this.withdrawPnl.Location = new System.Drawing.Point(23, 178);
            this.withdrawPnl.Name = "withdrawPnl";
            this.withdrawPnl.Size = new System.Drawing.Size(743, 330);
            this.withdrawPnl.TabIndex = 5;
            this.withdrawPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.withdrawPnl.VerticalScrollbarBarColor = true;
            this.withdrawPnl.VerticalScrollbarHighlightOnWheel = false;
            this.withdrawPnl.VerticalScrollbarSize = 10;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.withdrawBtn.Highlight = true;
            this.withdrawBtn.Location = new System.Drawing.Point(444, 160);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(89, 23);
            this.withdrawBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.withdrawBtn.TabIndex = 22;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // withdrawAmnt
            // 
            this.withdrawAmnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.withdrawAmnt.Location = new System.Drawing.Point(364, 160);
            this.withdrawAmnt.Name = "withdrawAmnt";
            this.withdrawAmnt.PromptText = "Amount";
            this.withdrawAmnt.Size = new System.Drawing.Size(74, 23);
            this.withdrawAmnt.TabIndex = 21;
            this.withdrawAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.withdrawAmnt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(229, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(129, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Withdrawal Amount:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // curBalLbl2
            // 
            this.curBalLbl2.AutoSize = true;
            this.curBalLbl2.Location = new System.Drawing.Point(364, 125);
            this.curBalLbl2.Name = "curBalLbl2";
            this.curBalLbl2.Size = new System.Drawing.Size(0, 0);
            this.curBalLbl2.TabIndex = 19;
            this.curBalLbl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(253, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Current Balance:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(341, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Withdraw";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lottoDatabaseDataSet1
            // 
            this.lottoDatabaseDataSet1.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 31);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 26;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // bankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 525);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.withdrawPnl);
            this.Controls.Add(this.depositPnl);
            this.Controls.Add(this.panelSlctCmboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bankForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.bankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.depositPnl.ResumeLayout(false);
            this.depositPnl.PerformLayout();
            this.withdrawPnl.ResumeLayout(false);
            this.withdrawPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox panelSlctCmboBox;
        private MetroFramework.Controls.MetroPanel depositPnl;
        private MetroFramework.Controls.MetroPanel withdrawPnl;
        private MetroFramework.Controls.MetroLabel curBalLbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox amountBox;
        private MetroFramework.Controls.MetroButton depositBtn;
        private MetroFramework.Controls.MetroLabel depositLmtLbl;
        private MetroFramework.Controls.MetroTextBox depositLmt;
        private MetroFramework.Controls.MetroButton depositLmtBtn;
        private MetroFramework.Controls.MetroButton withdrawBtn;
        private MetroFramework.Controls.MetroTextBox withdrawAmnt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel curBalLbl2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}