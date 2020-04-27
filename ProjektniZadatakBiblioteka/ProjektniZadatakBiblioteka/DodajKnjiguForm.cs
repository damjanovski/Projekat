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
    public partial class DodajKnjiguForm : Form
    {

        public DodajKnjiguForm()
        {
            InitializeComponent();

        }

        public bool Broj(string vrednost)
        {
            long n;
            try
            {
                n = long.Parse(vrednost);
                return true;
            } 
            catch
            {
                return false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<TextBox> lista = new List<TextBox>();
            lista.Add(textBox1);
            lista.Add(textBox2);
            lista.Add(textBox3);
            lista.Add(textBox4);

            foreach (TextBox t in lista)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") //Pokusao sam sa t.Text, medjutim, ako bih ostavio polje prazno i dalje bi proslo.
                {
                    MessageBox.Show("Niste popunili sva polja.");
                    break;
                }
                else if (textBox1.Text.Length != 13 || Broj(textBox1.Text) == false)
                {
                    MessageBox.Show("ISBN ne iznosi 13 cifara ili ste u polje slucajno uneli slovo umesto cifre.");
                    break;
                }
                else if (Broj(textBox4.Text) == false)
                {
                    MessageBox.Show("Niste uneli broj u polje: \"Godina izdanja knjige\".");
                    break;
                }
                else
                {
                    Program.gradska.DodajKnjigu(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
                    break;
                }
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
