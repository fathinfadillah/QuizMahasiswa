namespace QuizMahasiswa
{
	partial class MasterBarang016
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
			this.btnClose = new System.Windows.Forms.Button();
			this.dt = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.txtHarga = new System.Windows.Forms.TextBox();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbSupplier = new System.Windows.Forms.ComboBox();
			this.quizMahasiswaDataSet = new QuizMahasiswa.QuizMahasiswaDataSet();
			this.quizMahasiswaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_barangTableAdapter = new QuizMahasiswa.QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter();
			this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(180, 273);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(61, 26);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dt
			// 
			this.dt.AllowUserToAddRows = false;
			this.dt.AllowUserToDeleteRows = false;
			this.dt.AutoGenerateColumns = false;
			this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
			this.dt.DataSource = this.tblbarangBindingSource;
			this.dt.Location = new System.Drawing.Point(106, 319);
			this.dt.Margin = new System.Windows.Forms.Padding(2);
			this.dt.Name = "dt";
			this.dt.ReadOnly = true;
			this.dt.RowTemplate.Height = 24;
			this.dt.Size = new System.Drawing.Size(291, 110);
			this.dt.TabIndex = 46;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(106, 273);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(61, 26);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtStok
			// 
			this.txtStok.Location = new System.Drawing.Point(210, 196);
			this.txtStok.Margin = new System.Windows.Forms.Padding(2);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(187, 20);
			this.txtStok.TabIndex = 3;
			// 
			// txtHarga
			// 
			this.txtHarga.Location = new System.Drawing.Point(233, 150);
			this.txtHarga.Margin = new System.Windows.Forms.Padding(2);
			this.txtHarga.Name = "txtHarga";
			this.txtHarga.Size = new System.Drawing.Size(164, 20);
			this.txtHarga.TabIndex = 2;
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Location = new System.Drawing.Point(210, 103);
			this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(187, 20);
			this.txtNamaBarang.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(103, 235);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 32;
			this.label7.Text = "Nama Supplier";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(103, 196);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 31;
			this.label6.Text = "Stok";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(103, 152);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 30;
			this.label5.Text = "Harga";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(103, 108);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 29;
			this.label4.Text = "Nama Barang";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Renogare", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(144, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 29);
			this.label1.TabIndex = 27;
			this.label1.Text = "MASTER BARANG";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(207, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 47;
			this.label2.Text = "Rp";
			// 
			// cbSupplier
			// 
			this.cbSupplier.FormattingEnabled = true;
			this.cbSupplier.ItemHeight = 13;
			this.cbSupplier.Items.AddRange(new object[] {
            "iBox"});
			this.cbSupplier.Location = new System.Drawing.Point(210, 232);
			this.cbSupplier.Name = "cbSupplier";
			this.cbSupplier.Size = new System.Drawing.Size(187, 21);
			this.cbSupplier.TabIndex = 4;
			// 
			// quizMahasiswaDataSet
			// 
			this.quizMahasiswaDataSet.DataSetName = "QuizMahasiswaDataSet";
			this.quizMahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// quizMahasiswaDataSetBindingSource
			// 
			this.quizMahasiswaDataSetBindingSource.DataSource = this.quizMahasiswaDataSet;
			this.quizMahasiswaDataSetBindingSource.Position = 0;
			// 
			// tblbarangBindingSource
			// 
			this.tblbarangBindingSource.DataMember = "tbl_barang";
			this.tblbarangBindingSource.DataSource = this.quizMahasiswaDataSetBindingSource;
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
			this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hargaDataGridViewTextBoxColumn
			// 
			this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
			this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
			this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
			this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// stokDataGridViewTextBoxColumn
			// 
			this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
			this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
			this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
			this.stokDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// namasupplierDataGridViewTextBoxColumn
			// 
			this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
			this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
			this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
			this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// MasterBarang016
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 478);
			this.Controls.Add(this.cbSupplier);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.txtHarga);
			this.Controls.Add(this.txtNamaBarang);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "MasterBarang016";
			this.Text = "MasterBarang";
			this.Load += new System.EventHandler(this.MasterBarang016_Load);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dt;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.TextBox txtHarga;
		private System.Windows.Forms.TextBox txtNamaBarang;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbSupplier;
		private System.Windows.Forms.BindingSource quizMahasiswaDataSetBindingSource;
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

