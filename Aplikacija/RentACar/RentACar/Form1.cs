using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace RentACar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<Car> cars = new List<Car>();
			cars = DataProvider.getCars();
			foreach(Car car in cars)
			{
				MessageBox.Show("car: " + car.id.ToString() + " " + car.model.ToString());
			}
		}
	}
}
