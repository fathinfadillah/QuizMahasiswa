using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizMahasiswa
{
	public partial class MasterBarang016 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHKUU3D;Initial Catalog=QuizMahasiswa;Integrated Security=True;");

		public MasterBarang016()
		{
			InitializeComponent();
		}

		DataClasses1DataContext db = new DataClasses1DataContext();
		private void btnSave_Click(object sender, EventArgs e)
		{
			string barang = txtNamaBarang.Text;
			int harga = int.Parse(txtHarga.Text);
			int stok = int.Parse(txtStok.Text);
			string namasupplier = cbSupplier.Text;
			var data = new tbl_barang
			{
				nama_barang = barang,
				harga = harga,
				stok = stok,
				nama_supplier = namasupplier
			};
			db.tbl_barangs.InsertOnSubmit(data);
			db.SubmitChanges();
			MessageBox.Show("Save Successfully");
			txtNamaBarang.Clear();
			txtHarga.Clear();
			txtStok.Clear();
			cbSupplier.SelectedIndex = -1;
			LoadData();
		}

		void LoadData()
		{
			this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
			MasterBarang016 a = new MasterBarang016();
			a.Close();
		}

		private void MasterBarang016_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
			this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);

		}
	}
}
