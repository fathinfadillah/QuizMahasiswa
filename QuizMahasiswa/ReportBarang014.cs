using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuizMahasiswa
{
    public partial class ReportBarang014 : Form
    {
		public ReportBarang014()
		{
			InitializeComponent();
		}

		private void btnPDF_Click(object sender, EventArgs e)
		{
			exportgridtopdf(dt, "Report Barang");
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			exportgridtoexcel(dt, "Report Barang");
		}

		public void exportgridtopdf(DataGridView dgw, string filename)
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
			pdftable.DefaultCell.Padding = 3;
			pdftable.WidthPercentage = 100;
			pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdftable.DefaultCell.BorderWidth = 1;

			iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
			//Add header
			foreach (DataGridViewColumn column in dgw.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
				pdftable.AddCell(cell);
			}
			//Add datarow
			foreach (DataGridViewRow row in dgw.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
				}
			}

			var savefiledialoge = new SaveFileDialog();
			savefiledialoge.FileName = filename;
			savefiledialoge.DefaultExt = ".pdf";
			if (savefiledialoge.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
					PdfWriter.GetInstance(pdfdoc, stream);
					pdfdoc.Open();
					pdfdoc.Add(pdftable);
					pdfdoc.Close();
					stream.Close();
				}
			}
		}

		public void exportgridtoexcel(DataGridView dgw, string filename)
		{
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			worksheet = workbook.Sheets["Sheet1"];
			worksheet = workbook.ActiveSheet;

			for (int i = 1; i < dt.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = dt.Columns[i - 1].HeaderText;
			}

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				for (int j = 0; j < dt.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dt.Rows[i].Cells[j].Value.ToString();
				}
			}
			var saveFileDialogeExcel = new SaveFileDialog();
			saveFileDialogeExcel.FileName = "Excel Report Barang";
			saveFileDialogeExcel.DefaultExt = ".xlsx";

			if (saveFileDialogeExcel.ShowDialog() == DialogResult.OK)
			{
				workbook.SaveAs(saveFileDialogeExcel.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

			}
			app.Quit();
		}

		private void ReportBarang014_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
			this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);
			// TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
			this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);

		}
	}
}
