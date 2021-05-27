namespace QuizMahasiswa
{
    partial class ReportBarang014
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnPDF = new System.Windows.Forms.Button();
			this.quizMahasiswaDataSet = new QuizMahasiswa.QuizMahasiswaDataSet();
			this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_barangTableAdapter = new QuizMahasiswa.QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter();
			this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Renogare", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(258, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Report Barang";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblbarangBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(75, 107);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(544, 279);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(220, 439);
			this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(82, 26);
			this.btnExcel.TabIndex = 2;
			this.btnExcel.Text = "Export Excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnPDF
			// 
			this.btnPDF.Location = new System.Drawing.Point(392, 439);
			this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(82, 26);
			this.btnPDF.TabIndex = 2;
			this.btnPDF.Text = "Export PDF";
			this.btnPDF.UseVisualStyleBackColor = true;
			this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
			// 
			// quizMahasiswaDataSet
			// 
			this.quizMahasiswaDataSet.DataSetName = "QuizMahasiswaDataSet";
			this.quizMahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblbarangBindingSource
			// 
			this.tblbarangBindingSource.DataMember = "tbl_barang";
			this.tblbarangBindingSource.DataSource = this.quizMahasiswaDataSet;
			// 
			// tbl_barangTableAdapter
			// 
			this.tbl_barangTableAdapter.ClearBeforeFill = true;
			// 
			// idbarangDataGridViewTextBoxColumn
			// 
			this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
			this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
			this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
			this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// namabarangDataGridViewTextBoxColumn
			// 
			this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
			this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
			this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
			// 
			// hargaDataGridViewTextBoxColumn
			// 
			this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
			this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
			this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
			// 
			// stokDataGridViewTextBoxColumn
			// 
			this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
			this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
			this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
			// 
			// namasupplierDataGridViewTextBoxColumn
			// 
			this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
			this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
			this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
			// 
			// ReportBarang014
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 516);
			this.Controls.Add(this.btnPDF);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ReportBarang014";
			this.Text = "ReportBarabg";
			this.Load += new System.EventHandler(this.ReportBarang014_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
		private QuizMahasiswaDataSet quizMahasiswaDataSet;
		private System.Windows.Forms.BindingSource tblbarangBindingSource;
		private QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
	}
}