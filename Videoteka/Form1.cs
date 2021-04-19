using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Videoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PotvrdiPrijavu_Click(object sender, EventArgs e)
        {
            string KorisničkoIme, Lozinka;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Videoteka.Resources.KorisničkoIme.txt"))
            {
                TextReader tr = new StreamReader(stream);
                string KI = tr.ReadToEnd();
                KorisničkoIme = KI;
            }
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Videoteka.Resources.Lozinke.txt"))
            {
                TextReader tr = new StreamReader(stream);
                string L = tr.ReadToEnd();
                Lozinka = L;
            }
            if (lozinka.Text == Lozinka && korisnik.Text == KorisničkoIme)
            {
                //otvori novi prozor
                this.Hide();
                Form2 form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                //konekcija s bazom podataka


            }
            else
            {
                MessageBox.Show("Podatci su neispravni! Provjerite unesene podatke!");
                lozinka.Text = "";
                korisnik.Text = "";
            }
                

        }
    }
}
