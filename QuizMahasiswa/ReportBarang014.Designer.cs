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
			this.label1 = new System.Windows.Forms.Label();
			this.dt = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnPdf = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
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
			// dt
			// 
			this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt.Location = new System.Drawing.Point(56, 107);
			this.dt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dt.Name = "dt";
			this.dt.RowTemplate.Height = 24;
			this.dt.Size = new System.Drawing.Size(582, 279);
			this.dt.TabIndex = 1;
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(220, 439);
			this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(82, 26);
			this.btnExcel.TabIndex = 2;
			this.btnExcel.Text = "Export Excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// btnPdf
			// 
			this.btnPdf.Location = new System.Drawing.Point(392, 439);
			this.btnPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnPdf.Name = "btnPdf";
			this.btnPdf.Size = new System.Drawing.Size(82, 26);
			this.btnPdf.TabIndex = 2;
			this.btnPdf.Text = "Export PDF";
			this.btnPdf.UseVisualStyleBackColor = true;
			this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
			// 
			// ReportBarang014
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 516);
			this.Controls.Add(this.btnPdf);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ReportBarang014";
			this.Text = "ReportBarabg";
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
    }
}