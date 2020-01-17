namespace LotteryApplication
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.bankTile = new MetroFramework.Controls.MetroTile();
            this.drawsTile = new MetroFramework.Controls.MetroTile();
            this.prizeTile = new MetroFramework.Controls.MetroTile();
            this.accTile = new MetroFramework.Controls.MetroTile();
            this.logoutTile = new MetroFramework.Controls.MetroTile();
            this.lottoTile = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeLbl = new MetroFramework.Controls.MetroLabel();
            this.userLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userBalLbl = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.ticketsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.ticketsTableAdapter();
            this.adminPnlBtn = new MetroFramework.Controls.MetroButton();
            this.msgsTile = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.bankTile);
            this.metroPanel1.Controls.Add(this.drawsTile);
            this.metroPanel1.Controls.Add(this.prizeTile);
            this.metroPanel1.Controls.Add(this.accTile);
            this.metroPanel1.Controls.Add(this.logoutTile);
            this.metroPanel1.Controls.Add(this.lottoTile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(57, 99);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(573, 317);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // bankTile
            // 
            this.bankTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankTile.Location = new System.Drawing.Point(194, 3);
            this.bankTile.Name = "bankTile";
            this.bankTile.Size = new System.Drawing.Size(185, 154);
            this.bankTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.bankTile.TabIndex = 9;
            this.bankTile.Text = "View Bank";
            this.bankTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bankTile.TileImage = ((System.Drawing.Image)(resources.GetObject("bankTile.TileImage")));
            this.bankTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bankTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.bankTile.UseTileImage = true;
            this.bankTile.Click += new System.EventHandler(this.bankTile_Click);
            // 
            // drawsTile
            // 
            this.drawsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawsTile.Location = new System.Drawing.Point(385, 3);
            this.drawsTile.Name = "drawsTile";
            this.drawsTile.Size = new System.Drawing.Size(185, 154);
            this.drawsTile.Style = MetroFramework.MetroColorStyle.Pink;
            this.drawsTile.TabIndex = 8;
            this.drawsTile.Text = "View Past Draws";
            this.drawsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("drawsTile.TileImage")));
            this.drawsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.drawsTile.UseTileImage = true;
            this.drawsTile.Click += new System.EventHandler(this.drawsTile_Click);
            // 
            // prizeTile
            // 
            this.prizeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prizeTile.Location = new System.Drawing.Point(3, 163);
            this.prizeTile.Name = "prizeTile";
            this.prizeTile.Size = new System.Drawing.Size(185, 151);
            this.prizeTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.prizeTile.TabIndex = 6;
            this.prizeTile.Text = "Check Prizes";
            this.prizeTile.TileImage = ((System.Drawing.Image)(resources.GetObject("prizeTile.TileImage")));
            this.prizeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prizeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.prizeTile.UseTileImage = true;
            this.prizeTile.Click += new System.EventHandler(this.prizeTile_Click);
            // 
            // accTile
            // 
            this.accTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accTile.Location = new System.Drawing.Point(194, 163);
            this.accTile.Name = "accTile";
            this.accTile.Size = new System.Drawing.Size(185, 151);
            this.accTile.Style = MetroFramework.MetroColorStyle.Red;
            this.accTile.TabIndex = 5;
            this.accTile.Text = "View Account";
            this.accTile.TileImage = ((System.Drawing.Image)(resources.GetObject("accTile.TileImage")));
            this.accTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.accTile.UseTileImage = true;
            this.accTile.Click += new System.EventHandler(this.accTile_Click);
            // 
            // logoutTile
            // 
            this.logoutTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutTile.Location = new System.Drawing.Point(385, 163);
            this.logoutTile.Name = "logoutTile";
            this.logoutTile.Size = new System.Drawing.Size(185, 151);
            this.logoutTile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.logoutTile.TabIndex = 3;
            this.logoutTile.Text = "Logout";
            this.logoutTile.TileImage = ((System.Drawing.Image)(resources.GetObject("logoutTile.TileImage")));
            this.logoutTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.logoutTile.UseTileImage = true;
            this.logoutTile.Click += new System.EventHandler(this.logoutTile_Click);
            // 
            // lottoTile
            // 
            this.lottoTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lottoTile.Location = new System.Drawing.Point(3, 3);
            this.lottoTile.Name = "lottoTile";
            this.lottoTile.Size = new System.Drawing.Size(185, 154);
            this.lottoTile.Style = MetroFramework.MetroColorStyle.Green;
            this.lottoTile.TabIndex = 2;
            this.lottoTile.Text = "Play Lotto";
            this.lottoTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lottoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("lottoTile.TileImage")));
            this.lottoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lottoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.lottoTile.UseTileImage = true;
            this.lottoTile.Click += new System.EventHandler(this.lottoTile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.CustomForeColor = true;
            this.welcomeLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.welcomeLbl.ForeColor = System.Drawing.Color.White;
            this.welcomeLbl.Location = new System.Drawing.Point(462, 48);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(76, 19);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "Welcome:";
            this.welcomeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.CustomForeColor = true;
            this.userLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userLbl.ForeColor = System.Drawing.Color.White;
            this.userLbl.Location = new System.Drawing.Point(535, 48);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(0, 0);
            this.userLbl.TabIndex = 3;
            this.userLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userLbl.Click += new System.EventHandler(this.userLbl_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(463, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Balance:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // userBalLbl
            // 
            this.userBalLbl.AutoSize = true;
            this.userBalLbl.CustomForeColor = true;
            this.userBalLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userBalLbl.ForeColor = System.Drawing.Color.White;
            this.userBalLbl.Location = new System.Drawing.Point(533, 67);
            this.userBalLbl.Name = "userBalLbl";
            this.userBalLbl.Size = new System.Drawing.Size(0, 0);
            this.userBalLbl.TabIndex = 5;
            this.userBalLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // ticketsTableAdapter1
            // 
            this.ticketsTableAdapter1.ClearBeforeFill = true;
            // 
            // adminPnlBtn
            // 
            this.adminPnlBtn.Highlight = true;
            this.adminPnlBtn.Location = new System.Drawing.Point(57, 423);
            this.adminPnlBtn.Name = "adminPnlBtn";
            this.adminPnlBtn.Size = new System.Drawing.Size(573, 23);
            this.adminPnlBtn.TabIndex = 6;
            this.adminPnlBtn.Text = "Continue to Admin Panel";
            this.adminPnlBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adminPnlBtn.Click += new System.EventHandler(this.adminPnlBtn_Click);
            // 
            // msgsTile
            // 
            this.msgsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgsTile.CustomBackground = true;
            this.msgsTile.Location = new System.Drawing.Point(371, 52);
            this.msgsTile.Name = "msgsTile";
            this.msgsTile.Size = new System.Drawing.Size(40, 31);
            this.msgsTile.TabIndex = 7;
            this.msgsTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.msgsTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.msgsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("msgsTile.TileImage")));
            this.msgsTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msgsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.msgsTile.UseTileImage = true;
            this.msgsTile.Click += new System.EventHandler(this.msgsTile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // drawsTableAdapter1
            // 
            this.drawsTableAdapter1.ClearBeforeFill = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 459);
            this.Controls.Add(this.msgsTile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.adminPnlBtn);
            this.Controls.Add(this.userBalLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile bankTile;
        private MetroFramework.Controls.MetroTile drawsTile;
        private MetroFramework.Controls.MetroTile prizeTile;
        private MetroFramework.Controls.MetroTile accTile;
        private MetroFramework.Controls.MetroTile logoutTile;
        private MetroFramework.Controls.MetroTile lottoTile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel welcomeLbl;
        private MetroFramework.Controls.MetroLabel userLbl;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel userBalLbl;
        private System.Windows.Forms.Timer timer1;
        private lottoDatabaseDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter1;
        private MetroFramework.Controls.MetroButton adminPnlBtn;
        private MetroFramework.Controls.MetroTile msgsTile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
    }
}

