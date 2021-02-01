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
    public partial class Pregledaj : Form
    {
        public Pregledaj()
        {
            InitializeComponent();
        }

        private void Pregledaj_Load(object sender, EventArgs e)
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
                    Filmovi.Items.Add(stringovi[0]);
                    Količina.Items.Add(stringovi[1]);
                }
            }
                
        }
    }
}
