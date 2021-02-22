using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;

namespace Videoteka
{
    public class Korisnici
    {
        public static ArrayList PopisKor = new ArrayList();
        public static void DohvatiKorisnike()
        {
            int i = 0;
            string[] stringovi;
            string line;
            
            using (StreamReader file = new StreamReader(Assembly.
                  GetExecutingAssembly().GetManifestResourceStream
                  ("Videoteka.Resources.Korisnici.txt")))
            {
                while ((line = file.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                    stringovi = line.Split(',');
                    PopisKor.Add(stringovi[0]);
                }
            }
        }
    }
}
