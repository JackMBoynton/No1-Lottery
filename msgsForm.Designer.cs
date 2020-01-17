namespace LotteryApplication
{
    partial class msgsForm
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
            this.usrMsgsDGV = new System.Windows.Forms.DataGridView();
            this.msgIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrMsgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lottoDatabaseDataSet = new LotteryApplication.lottoDatabaseDataSet();
            this.usrMsgsTableAdapter = new LotteryApplication.lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usrMsgsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrMsgsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usrMsgsDGV
            // 
            this.usrMsgsDGV.AllowUserToAddRows = false;
            this.usrMsgsDGV.AllowUserToDeleteRows = false;
            this.usrMsgsDGV.AutoGenerateColumns = false;
            this.usrMsgsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrMsgsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msgIDDataGridViewTextBoxColumn,
            this.usrIDDataGridViewTextBoxColumn,
            this.msgSubjectDataGridViewTextBoxColumn,
            this.msgBodyDataGridViewTextBoxColumn});
            this.usrMsgsDGV.DataSource = this.usrMsgsBindingSource;
            this.usrMsgsDGV.Location = new System.Drawing.Point(20, 56);
            this.usrMsgsDGV.Name = "usrMsgsDGV";
            this.usrMsgsDGV.ReadOnly = true;
            this.usrMsgsDGV.Size = new System.Drawing.Size(1060, 312);
            this.usrMsgsDGV.TabIndex = 0;
            this.usrMsgsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // msgIDDataGridViewTextBoxColumn
            // 
            this.msgIDDataGridViewTextBoxColumn.DataPropertyName = "msgID";
            this.msgIDDataGridViewTextBoxColumn.HeaderText = "msgID";
            this.msgIDDataGridViewTextBoxColumn.Name = "msgIDDataGridViewTextBoxColumn";
            this.msgIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.msgIDDataGridViewTextBoxColumn.Width = 179;
            // 
            // usrIDDataGridViewTextBoxColumn
            // 
            this.usrIDDataGridViewTextBoxColumn.DataPropertyName = "usrID";
            this.usrIDDataGridViewTextBoxColumn.HeaderText = "usrID";
            this.usrIDDataGridViewTextBoxColumn.Name = "usrIDDataGridViewTextBoxColumn";
            this.usrIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usrIDDataGridViewTextBoxColumn.Width = 178;
            // 
            // msgSubjectDataGridViewTextBoxColumn
            // 
            this.msgSubjectDataGridViewTextBoxColumn.DataPropertyName = "msgSubject";
            this.msgSubjectDataGridViewTextBoxColumn.HeaderText = "msgSubject";
            this.msgSubjectDataGridViewTextBoxColumn.Name = "msgSubjectDataGridViewTextBoxColumn";
            this.msgSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.msgSubjectDataGridViewTextBoxColumn.Width = 179;
            // 
            // msgBodyDataGridViewTextBoxColumn
            // 
            this.msgBodyDataGridViewTextBoxColumn.DataPropertyName = "msgBody";
            this.msgBodyDataGridViewTextBoxColumn.HeaderText = "msgBody";
            this.msgBodyDataGridViewTextBoxColumn.Name = "msgBodyDataGridViewTextBoxColumn";
            this.msgBodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.msgBodyDataGridViewTextBoxColumn.Width = 178;
            // 
            // usrMsgsBindingSource
            // 
            this.usrMsgsBindingSource.DataMember = "usrMsgs";
            this.usrMsgsBindingSource.DataSource = this.lottoDatabaseDataSet;
            // 
            // lottoDatabaseDataSet
            // 
            this.lottoDatabaseDataSet.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usrMsgsTableAdapter
            // 
            this.usrMsgsTableAdapter.ClearBeforeFill = true;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(20, 19);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 8;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // msgsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 391);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.usrMsgsDGV);
            this.Name = "msgsForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.msgsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usrMsgsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrMsgsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usrMsgsDGV;
        private lottoDatabaseDataSet lottoDatabaseDataSet;
        private System.Windows.Forms.BindingSource usrMsgsBindingSource;
        private lottoDatabaseDataSetTableAdapters.usrMsgsTableAdapter usrMsgsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgBodyDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}