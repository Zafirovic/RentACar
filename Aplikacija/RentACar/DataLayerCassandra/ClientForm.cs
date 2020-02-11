using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayerCassandra
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider.AddClient(jmbgTextBox.Text, imeTextBox.Text, prezimeTextBox.Text);
            Close();
        }

        public string getJMBG()
        {
            return jmbgTextBox.Text;
        }

		public string brojDanaIznajmljivanja()
		{
			return brojDanaTextBox.Text;
		}
    }
}
