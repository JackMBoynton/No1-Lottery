namespace LotteryApplication
{
    partial class lottoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lottoForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchaseBtn = new MetroFramework.Controls.MetroButton();
            this.viewBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.sessionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Highlight = true;
            this.purchaseBtn.Location = new System.Drawing.Point(213, 188);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(261, 51);
            this.purchaseBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase a No. 1 Lottery Ticket!";
            this.purchaseBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Highlight = true;
            this.viewBtn.Location = new System.Drawing.Point(213, 245);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(261, 51);
            this.viewBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.viewBtn.TabIndex = 4;
            this.viewBtn.Text = "View the LATEST Draw";
            this.viewBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(289, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Play Lotto!";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 31);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 6;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // drawsTableAdapter1
            // 
            this.drawsTableAdapter1.ClearBeforeFill = true;
            // 
            // lottoDatabaseDataSet1
            // 
            this.lottoDatabaseDataSet1.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionTimer
            // 
            this.sessionTimer.Enabled = true;
            this.sessionTimer.Tick += new System.EventHandler(this.sessionTimer_Tick);
            // 
            // lottoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 434);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lottoForm";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.lottoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton purchaseBtn;
        private MetroFramework.Controls.MetroButton viewBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel backLbl;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private System.Windows.Forms.Timer sessionTimer;
    }
}