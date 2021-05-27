using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MasterBarang016 a = new MasterBarang016();
			a.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ReportBarang014 b = new ReportBarang014();
			b.Show();
		}
	}
}
