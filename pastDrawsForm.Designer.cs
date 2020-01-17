namespace LotteryApplication
{
    partial class pastDrawsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lottoDatabaseDataSet = new LotteryApplication.lottoDatabaseDataSet();
            this.drawsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawsTableAdapter = new LotteryApplication.lottoDatabaseDataSetTableAdapters.drawsTableAdapter();
            this.drawCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDrawDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.backLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drawCodeDataGridViewTextBoxColumn,
            this.drawDatesDataGridViewTextBoxColumn,
            this.num1DataGridViewTextBoxColumn,
            this.num2DataGridViewTextBoxColumn,
            this.num3DataGridViewTextBoxColumn,
            this.num4DataGridViewTextBoxColumn,
            this.num5DataGridViewTextBoxColumn,
            this.pastDrawDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.drawsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(851, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lottoDatabaseDataSet
            // 
            this.lottoDatabaseDataSet.DataSetName = "lottoDatabaseDataSet";
            this.lottoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drawsBindingSource
            // 
            this.drawsBindingSource.DataMember = "draws";
            this.drawsBindingSource.DataSource = this.lottoDatabaseDataSet;
            // 
            // drawsTableAdapter
            // 
            this.drawsTableAdapter.ClearBeforeFill = true;
            // 
            // drawCodeDataGridViewTextBoxColumn
            // 
            this.drawCodeDataGridViewTextBoxColumn.DataPropertyName = "drawCode";
            this.drawCodeDataGridViewTextBoxColumn.HeaderText = "drawCode";
            this.drawCodeDataGridViewTextBoxColumn.Name = "drawCodeDataGridViewTextBoxColumn";
            this.drawCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drawDatesDataGridViewTextBoxColumn
            // 
            this.drawDatesDataGridViewTextBoxColumn.DataPropertyName = "drawDates";
            this.drawDatesDataGridViewTextBoxColumn.HeaderText = "drawDates";
            this.drawDatesDataGridViewTextBoxColumn.Name = "drawDatesDataGridViewTextBoxColumn";
            this.drawDatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num1DataGridViewTextBoxColumn
            // 
            this.num1DataGridViewTextBoxColumn.DataPropertyName = "num1";
            this.num1DataGridViewTextBoxColumn.HeaderText = "num1";
            this.num1DataGridViewTextBoxColumn.Name = "num1DataGridViewTextBoxColumn";
            this.num1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num2DataGridViewTextBoxColumn
            // 
            this.num2DataGridViewTextBoxColumn.DataPropertyName = "num2";
            this.num2DataGridViewTextBoxColumn.HeaderText = "num2";
            this.num2DataGridViewTextBoxColumn.Name = "num2DataGridViewTextBoxColumn";
            this.num2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num3DataGridViewTextBoxColumn
            // 
            this.num3DataGridViewTextBoxColumn.DataPropertyName = "num3";
            this.num3DataGridViewTextBoxColumn.HeaderText = "num3";
            this.num3DataGridViewTextBoxColumn.Name = "num3DataGridViewTextBoxColumn";
            this.num3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num4DataGridViewTextBoxColumn
            // 
            this.num4DataGridViewTextBoxColumn.DataPropertyName = "num4";
            this.num4DataGridViewTextBoxColumn.HeaderText = "num4";
            this.num4DataGridViewTextBoxColumn.Name = "num4DataGridViewTextBoxColumn";
            this.num4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // num5DataGridViewTextBoxColumn
            // 
            this.num5DataGridViewTextBoxColumn.DataPropertyName = "num5";
            this.num5DataGridViewTextBoxColumn.HeaderText = "num5";
            this.num5DataGridViewTextBoxColumn.Name = "num5DataGridViewTextBoxColumn";
            this.num5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pastDrawDataGridViewCheckBoxColumn
            // 
            this.pastDrawDataGridViewCheckBoxColumn.DataPropertyName = "pastDraw";
            this.pastDrawDataGridViewCheckBoxColumn.HeaderText = "pastDraw";
            this.pastDrawDataGridViewCheckBoxColumn.Name = "pastDrawDataGridViewCheckBoxColumn";
            this.pastDrawDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.backLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.backLbl.Location = new System.Drawing.Point(9, 20);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(71, 25);
            this.backLbl.TabIndex = 9;
            this.backLbl.Text = "< Back";
            this.backLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backLbl.UseStyleColors = true;
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // pastDrawsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 315);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pastDrawsForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pastDrawsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private lottoDatabaseDataSet lottoDatabaseDataSet;
        private System.Windows.Forms.BindingSource drawsBindingSource;
        private lottoDatabaseDataSetTableAdapters.drawsTableAdapter drawsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pastDrawDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroLabel backLbl;
    }
}