namespace LotteryApplication
{
    partial class logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userBox = new MetroFramework.Controls.MetroTextBox();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.logInBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.signUpLbl = new MetroFramework.Controls.MetroLabel();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.sessionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(259, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Log In";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userBox
            // 
            this.userBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userBox.Location = new System.Drawing.Point(212, 209);
            this.userBox.Name = "userBox";
            this.userBox.PromptText = "Enter Username Here";
            this.userBox.Size = new System.Drawing.Size(157, 23);
            this.userBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.userBox.TabIndex = 5;
            this.userBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // passBox
            // 
            this.passBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBox.Location = new System.Drawing.Point(212, 257);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.PromptText = "Enter Password Here";
            this.passBox.Size = new System.Drawing.Size(157, 23);
            this.passBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.TabIndex = 6;
            this.passBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(212, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Username:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(212, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Password:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // logInBtn
            // 
            this.logInBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInBtn.Highlight = true;
            this.logInBtn.Location = new System.Drawing.Point(212, 292);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(157, 37);
            this.logInBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.logInBtn.TabIndex = 9;
            this.logInBtn.Text = "Enter No. 1 Lotto";
            this.logInBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logInBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(193, 337);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(146, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Don\'t Have an Account?";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // signUpLbl
            // 
            this.signUpLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLbl.Location = new System.Drawing.Point(337, 337);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(59, 19);
            this.signUpLbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.signUpLbl.TabIndex = 13;
            this.signUpLbl.Text = "Sign Up!";
            this.signUpLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.signUpLbl.UseStyleColors = true;
            this.signUpLbl.Click += new System.EventHandler(this.metroLabel5_Click);
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
            // sessionTimer
            // 
            this.sessionTimer.Enabled = true;
            this.sessionTimer.Tick += new System.EventHandler(this.sessionTimer_Tick);
            // 
            // logIn
            // 
            this.AcceptButton = this.logInBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 408);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "logIn";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.logIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox userBox;
        private MetroFramework.Controls.MetroTextBox passBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton logInBtn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel signUpLbl;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Timer sessionTimer;
    }
}