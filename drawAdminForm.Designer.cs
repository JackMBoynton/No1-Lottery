namespace LotteryApplication
{
    partial class drawAdminForm
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
            this.drawsTableAdapter1 = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.drawBtn = new MetroFramework.Controls.MetroButton();
            this.refreshTmr = new System.Windows.Forms.Timer(this.components);
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // drawBtn
            // 
            this.drawBtn.Highlight = true;
            this.drawBtn.Location = new System.Drawing.Point(112, 73);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(195, 73);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Draw the Numbers";
            this.drawBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // refreshTmr
            // 
            this.refreshTmr.Tick += new System.EventHandler(this.refreshTmr_Tick);
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(23, 24);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 9;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // drawAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 183);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.drawBtn);
            this.Name = "drawAdminForm";
            this.Text = "Start Latest Draw";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.realtimeDrawBG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lottoDatabaseDataSet lottoDatabaseDataSet1;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter1;
        private MetroFramework.Controls.MetroButton drawBtn;
        private System.Windows.Forms.Timer refreshTmr;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}