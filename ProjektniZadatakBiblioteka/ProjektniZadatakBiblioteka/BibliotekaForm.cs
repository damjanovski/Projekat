using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatakBiblioteka
{
    public partial class BibliotekaForm : Form
    {
        public BibliotekaForm()
        {
            InitializeComponent();
        }

        private void AzurirajListBox1()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Program.gradska.listaKnjiga.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Biblioteka.PodaciOBiblioteci());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DodajKnjiguForm dodajKnjigu = new DodajKnjiguForm();
            dodajKnjigu.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Knjiga k = (Knjiga)listBox1.SelectedItem;
                Program.gradska.listaKnjiga.Remove(k);
                AzurirajListBox1();
                MessageBox.Show("Izabrali ste knjigu \n\r i obrisali je: " + k.ToString());
            }
            catch
            {
                MessageBox.Show("Niste izabrali nijednu knjigu.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AzurirajListBox1();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Knjiga k = (Knjiga)listBox1.SelectedItem;
            MessageBox.Show("Izabrali ste knjigu: \n\r" + k.ToString());
        }
    }
}
