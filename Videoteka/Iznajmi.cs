using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;

namespace Videoteka
{
    public partial class Iznajmi : Form
    {
        public Iznajmi()
        {
            InitializeComponent();
        }
        public ArrayList Filmovi = new ArrayList();
        private void Iznajmi_Load(object sender, EventArgs e)
        {

            string line;
            string[] stringovi;
            using (StreamReader file = new StreamReader(Assembly.
                GetExecutingAssembly().GetManifestResourceStream
                ("Videoteka.Resources.BazaFilmova.txt")))
            {
                while ((line = file.ReadLine()) != null)
                {
                    stringovi = line.Split(',');
                    ListaFilmova.Items.Add(stringovi[0]);
                }
            }
            foreach (var item in Korisnici.PopisKor)
            {
                ListaKorisnika.Items.Add(item);
            }

            using (StreamReader file = new StreamReader(Assembly.
                  GetExecutingAssembly().GetManifestResourceStream
                  ("Videoteka.Resources.BazaFilmova.txt")))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Filmovi.Add(line);
                }
            }
        }

        private void IznajmiButton_Click(object sender, EventArgs e)
        {
            //U datoteku Iznajmljivanja.txt dodati text u obliku korisnik +
            //iznajmljeni film.
            ListaFilmova.SelectedItem.ToString();
            string str = ListaFilmova.SelectedItem.ToString() + "," + ListaKorisnika.SelectedItem.ToString();
            using (StreamWriter stream = new StreamWriter(@"C:\Users\Korisnik\source\repos\Videoteka\Videoteka\Resources\Iznajmljivanja.txt"))
            {
                stream.WriteLine(str);
                MessageBox.Show("Rezervacija filma uspješno dodana!");
            }

            //promijena količine filmova
            string[] Podijeli = new string[] { };
            
        }
    }
}

