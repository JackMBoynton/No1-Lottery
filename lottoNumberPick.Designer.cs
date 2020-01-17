namespace LotteryApplication
{
    partial class lottoNumberPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lottoNumberPick));
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.num1Pick = new System.Windows.Forms.NumericUpDown();
            this.num2Pick = new System.Windows.Forms.NumericUpDown();
            this.num3Pick = new System.Windows.Forms.NumericUpDown();
            this.num4Pick = new System.Windows.Forms.NumericUpDown();
            this.num5Pick = new System.Windows.Forms.NumericUpDown();
            this.prchseTktBtn = new MetroFramework.Controls.MetroButton();
            this.ticketsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.ticketsTableAdapter();
            this.lottoDatabaseDataSet1 = new LotteryApplication.lottoDatabaseDataSet();
            this.drawDatesCmboBox = new MetroFramework.Controls.MetroComboBox();
            this.drawsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.usersTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usersTableAdapter();
            this.luckyDipBtn = new MetroFramework.Controls.MetroButton();
            this.sessionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 37);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 8;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // num1Pick
            // 
            this.num1Pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.num1Pick.ForeColor = System.Drawing.Color.White;
            this.num1Pick.Location = new System.Drawing.Point(201, 204);
            this.num1Pick.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num1Pick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num1Pick.Name = "num1Pick";
            this.num1Pick.Size = new System.Drawing.Size(43, 20);
            this.num1Pick.TabIndex = 9;
            this.num1Pick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num2Pick
            // 
            this.num2Pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.num2Pick.ForeColor = System.Drawing.Color.White;
            this.num2Pick.Location = new System.Drawing.Point(250, 204);
            this.num2Pick.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num2Pick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num2Pick.Name = "num2Pick";
            this.num2Pick.Size = new System.Drawing.Size(43, 20);
            this.num2Pick.TabIndex = 10;
            this.num2Pick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num3Pick
            // 
            this.num3Pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.num3Pick.ForeColor = System.Drawing.Color.White;
            this.num3Pick.Location = new System.Drawing.Point(299, 204);
            this.num3Pick.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num3Pick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num3Pick.Name = "num3Pick";
            this.num3Pick.Size = new System.Drawing.Size(43, 20);
            this.num3Pick.TabIndex = 11;
            this.num3Pick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num4Pick
            // 
            this.num4Pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.num4Pick.ForeColor = System.Drawing.Color.White;
            this.num4Pick.Location = new System.Drawing.Point(348, 204);
            this.num4Pick.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num4Pick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num4Pick.Name = "num4Pick";
            this.num4Pick.Size = new System.Drawing.Size(43, 20);
            this.num4Pick.TabIndex = 12;
            this.num4Pick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num5Pick
            // 
            this.num5Pick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.num5Pick.ForeColor = System.Drawing.Color.White;
            this.num5Pick.Location = new System.Drawing.Point(397, 204);
            this.num5Pick.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.num5Pick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num5Pick.Name = "num5Pick";
            this.num5Pick.Size = new System.Drawing.Size(43, 20);
            this.num5Pick.TabIndex = 13;
            this.num5Pick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // prchseTktBtn
            // 
            this.prchseTktBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prchseTktBtn.Highlight = true;
            this.prchseTktBtn.Location = new System.Drawing.Point(201, 259);
            this.prchseTktBtn.Name = "prchseTktBtn";
            this.prchseTktBtn.Size = new System.Drawing.Size(239, 37);
            this.prchseTktBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.prchseTktBtn.TabIndex = 14;
            this.prchseTktBtn.Text = "Purchase Ticket";
            this.prchseTktBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.prchseTktBtn.Click += new System.EventHandler(this.prchseTktBtn_Click);
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
            // drawDatesCmboBox
            // 
            this.drawDatesCmboBox.DataSource = this.drawsBindingSource;
            this.drawDatesCmboBox.DisplayMember = "drawDates";
            this.drawDatesCmboBox.FormattingEnabled = true;
            this.drawDatesCmboBox.ItemHeight = 23;
            this.drawDatesCmboBox.Location = new System.Drawing.Point(201, 168);
            this.drawDatesCmboBox.Name = "drawDatesCmboBox";
            this.drawDatesCmboBox.Size = new System.Drawing.Size(239, 29);
            this.drawDatesCmboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.drawDatesCmboBox.TabIndex = 15;
            this.drawDatesCmboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.drawDatesCmboBox.ValueMember = "drawCode";
            // 
            // drawsBindingSource
            // 
            this.drawsBindingSource.DataMember = "draws";
            this.drawsBindingSource.DataSource = this.lottoDatabaseDataSet1;
            // 
            // drawsTableAdapter1
            // 
            this.drawsTableAdapter1.ClearBeforeFill = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(201, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Pick Draw Date:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // luckyDipBtn
            // 
            this.luckyDipBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luckyDipBtn.Highlight = true;
            this.luckyDipBtn.Location = new System.Drawing.Point(201, 230);
            this.luckyDipBtn.Name = "luckyDipBtn";
            this.luckyDipBtn.Size = new System.Drawing.Size(239, 23);
            this.luckyDipBtn.TabIndex = 17;
            this.luckyDipBtn.Text = "Lucky Dip";
            this.luckyDipBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.luckyDipBtn.Click += new System.EventHandler(this.luckyDipBtn_Click);
            // 
            // sessionTimer
            // 
            this.sessionTimer.Enabled = true;
            this.sessionTimer.Tick += new System.EventHandler(this.sessionTimer_Tick);
            // 
            // lottoNumberPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 434);
            this.Controls.Add(this.luckyDipBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.drawDatesCmboBox);
            this.Controls.Add(this.prchseTktBtn);
            this.Controls.Add(this.num5Pick);
            this.Controls.Add(this.num4Pick);
            this.Controls.Add(this.num3Pick);
            this.Controls.Add(this.num2Pick);
            this.Controls.Add(this.num1Pick);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lottoNumberPick";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.lottoDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel backLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown num1Pick;
        private System.Windows.Forms.NumericUpDown num2Pick;
        private System.Windows.Forms.NumericUpDown num3Pick;
        private System.Windows.Forms.NumericUpDown num4Pick;
        private System.Windows.Forms.NumericUpDown num5Pick;
        private MetroFramework.Controls.MetroButton prchseTktBtn;
        private lottoDatabaseDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter1;
        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private MetroFramework.Controls.MetroComboBox drawDatesCmboBox;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
        private System.Windows.Forms.BindingSource drawsBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private lottoDatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private MetroFramework.Controls.MetroButton luckyDipBtn;
        private System.Windows.Forms.Timer sessionTimer;
    }
}