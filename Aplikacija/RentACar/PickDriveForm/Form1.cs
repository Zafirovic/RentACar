using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayerCassandra;
using DataLayerCassandra.Entiteti;

namespace PickDriveForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajVozilo_click(object sender, EventArgs e)
        {
            if (id_vozila_txt.TextLength == 0)
                MessageBox.Show("Unesite id vozila koje zelite dodati u bazu!");
            else if (tip_txt.TextLength == 0)
                MessageBox.Show("Unesite tip vozila koje zelite dodati u bazu!");
            else if (naziv_vozila_txt.TextLength == 0)
                MessageBox.Show("Unesite naziv vozila koje zelite dodati u bazu!");
            else if (model_vozila_txt.TextLength == 0)
                MessageBox.Show("Unesite model vozila koje zelite dodati u bazu!");
            else {
                DataProvider.AddVozilo(id_vozila_txt.Text,"Slobodno", tip_txt.Text, naziv_vozila_txt.Text, model_vozila_txt.Text);
                MessageBox.Show(tip_txt.Text + " uspesno dodat u bazu!");
            }
        }

        private void DeleteVozilo_Click(object sender, EventArgs e)
        {
            if (id_vozilaDel_txt.TextLength == 0)
                MessageBox.Show("Unesite id vozila koje zelite obrisati iz baze!");
            else {
                DataProvider.DeleteVozilo(id_vozilaDel_txt.Text);
                MessageBox.Show("Vozilo sa rednim brojem:" + id_vozilaDel_txt.Text + " je uspesno obrisano iz baze!");
            }
        }

        private void GetVozila_Click(object sender, EventArgs e)
        {
            List<Vozila> vozila = DataProvider.GetVozila();

            foreach (Vozila v in vozila)
                MessageBox.Show(v.id_vozila + ": " + v.tip + ":\n" + v.naziv + "  " + v.model);
        }

        private void GetRadnik_Click(object sender, EventArgs e)
        {
            List<Radnik> radniks = DataProvider.GetRadnici();

            foreach (Radnik r in radniks)
                MessageBox.Show(r.id_radnika + ": " + r.ime_radnika + "  " + r.prezime_radnika);
        }

        private void AddRadnik_Click(object sender, EventArgs e)
        {
            if (id_radnik_txt.TextLength == 0)
                MessageBox.Show("Unesite id radnika koga zelite dodati u bazu!");
            else if (ime_radnik_txt.TextLength == 0)
                MessageBox.Show("Unesite ime radnika koga zelite dodati u bazu!");
            else if (prezime_radnik_txt.TextLength == 0)
                MessageBox.Show("Unesite prezime radnika koga zelite dodati u bazu!");
            else
            {
                DataProvider.AddRadnik(id_radnik_txt.Text, ime_radnik_txt.Text, prezime_radnik_txt.Text);
                MessageBox.Show("Radnik:  " + ime_radnik_txt.Text + "  " + prezime_radnik_txt.Text + "  uspesno dodat u bazu!");

            }
        }

        private void DeleteRadnik_Click(object sender, EventArgs e)
        {
            if (id_radnikDel_txt.TextLength == 0)
                MessageBox.Show("Unesite id radnika koga zelite obrisati iz baze!");
            else {
                DataProvider.DeleteRadnik(id_radnikDel_txt.Text);
                MessageBox.Show("Radnik sa rednim brojem: " + id_radnikDel_txt.Text + " uspesno obrisan iz baze!");
            }
        }

        private void RentVozilo_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.ShowDialog();

        }

		private void notReturnedBtn_Click(object sender, EventArgs e)
		{
			List<Client> klijenti = DataProvider.GetClients();
			foreach(Client klijent in klijenti)
			{
				string rent = DataProvider.GetDateToReturn(klijent.jmbg);
				MessageBox.Show("Jmbg: "+ klijent.jmbg + "\nIme: " + klijent.ime_client + "\nPrezime: " + klijent.prezime_client + "\nDatum vracanja vozila: " + rent);
			}
		}
	}
}
