namespace LotteryApplication
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.signUpBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.userBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.emailBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.firstBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lastBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpBtn.Highlight = true;
            this.signUpBtn.Location = new System.Drawing.Point(227, 511);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(157, 37);
            this.signUpBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.signUpBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(227, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Password:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(227, 195);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Username:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // passBox
            // 
            this.passBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBox.Location = new System.Drawing.Point(227, 265);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.PromptText = "Enter Password Here";
            this.passBox.Size = new System.Drawing.Size(157, 23);
            this.passBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.TabIndex = 2;
            this.passBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userBox
            // 
            this.userBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userBox.Location = new System.Drawing.Point(227, 217);
            this.userBox.Name = "userBox";
            this.userBox.PromptText = "Enter Username Here";
            this.userBox.Size = new System.Drawing.Size(157, 23);
            this.userBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.userBox.TabIndex = 1;
            this.userBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(270, 160);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Sign Up";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(227, 293);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Email:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.Location = new System.Drawing.Point(227, 315);
            this.emailBox.Name = "emailBox";
            this.emailBox.PromptText = "Enter Password Here";
            this.emailBox.Size = new System.Drawing.Size(157, 23);
            this.emailBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailBox.TabIndex = 3;
            this.emailBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(227, 344);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "First Name:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // firstBox
            // 
            this.firstBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstBox.Location = new System.Drawing.Point(227, 366);
            this.firstBox.Name = "firstBox";
            this.firstBox.PromptText = "Enter Password Here";
            this.firstBox.Size = new System.Drawing.Size(157, 23);
            this.firstBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstBox.TabIndex = 4;
            this.firstBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(227, 395);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Last Name:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lastBox
            // 
            this.lastBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastBox.Location = new System.Drawing.Point(227, 417);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(157, 23);
            this.lastBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastBox.TabIndex = 5;
            this.lastBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(227, 446);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Date of Birth:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // dobPicker
            // 
            this.dobPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobPicker.Location = new System.Drawing.Point(227, 468);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(157, 20);
            this.dobPicker.TabIndex = 6;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 31);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 25;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 613);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "signUpForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.signUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton signUpBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox passBox;
        private MetroFramework.Controls.MetroTextBox userBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox emailBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox firstBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox lastBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}