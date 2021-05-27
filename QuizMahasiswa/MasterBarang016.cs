﻿using System;
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
			var st = from tb in db.tbl_barangs select tb;
			dt.DataSource = st;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
			MasterBarang016 a = new MasterBarang016();
			a.Close();
		}
	}
}
