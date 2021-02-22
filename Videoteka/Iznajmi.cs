using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Videoteka
{
    public partial class Iznajmi : Form
    {
        public Iznajmi()
        {
            InitializeComponent();
        }

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
        }

        private void IznajmiButton_Click(object sender, EventArgs e)
        {
            //U datoteku Iznajmljivanja.txt dodati text u obliku korisnik +
            //iznajmljeni film.
            ListaFilmova.SelectedItem.ToString();
            
        }
    }
}
