using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayerCassandra.Entiteti;

namespace DataLayerCassandra
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
            listVozila("Automobil", comboBox2.SelectedIndex);
        }

        public void listVozila(string tip, int stanje)
        {
			if (stanje == 0)
			{
				iznajmi_btn.Enabled = true;
				Oslobodi.Enabled = false;
			}
			else
			{
				Oslobodi.Enabled = true;
				iznajmi_btn.Enabled = false;
			}
            List<Vozila> vozila = new List<Vozila>();
            DataTable dt = new DataTable();

            vozila = DataProvider.GetVozilaTip(tip);
            dt.Columns.Add("id");
            dt.Columns.Add("naziv");
            dt.Columns.Add("model");

            foreach (Vozila v in vozila)
            {
				if (v.isrent.Equals("Slobodno") && stanje == 0)
					dt.Rows.Add(v.id_vozila, v.naziv, v.model);
				else if (v.isrent.Equals("Zauzeto") && stanje == 1)
					dt.Rows.Add(v.id_vozila, v.naziv, v.model);
            }
            dataGridView1.DataSource = dt;

			if (dataGridView1.Rows.Count == 1)
			{
				iznajmi_btn.Enabled = false;
				Oslobodi.Enabled = false;
			}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listVozila("Automobil", comboBox2.SelectedIndex);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listVozila("Motor", comboBox2.SelectedIndex);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listVozila("Bicikl", comboBox2.SelectedIndex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void iznajmi_btn_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.ShowDialog();
            string jmbg = cf.getJMBG();
			string brojDana = cf.brojDanaIznajmljivanja();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                DataProvider.updateState("Zauzeto", id);
                Random r = new Random();
                string rentID = r.Next(0, 10000).ToString();
                DataProvider.addRent(rentID, id, jmbg, Convert.ToInt32(brojDana));
            }
            listVozila(comboBox1.GetItemText(this.comboBox1.SelectedItem), comboBox2.SelectedIndex);
        }

        private void Oslobodi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                DataProvider.updateState("Slobodno", id);
                DataProvider.removeRent(id);
            }
            listVozila(comboBox1.GetItemText(this.comboBox1.SelectedItem), comboBox2.SelectedIndex);
        }

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			listVozila(comboBox1.GetItemText(this.comboBox1.SelectedItem), comboBox2.SelectedIndex);
		}
	}
}
