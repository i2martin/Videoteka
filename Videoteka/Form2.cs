using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Zatvori_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Pregledaj_Click(object sender, EventArgs e)
        {
            ImeProzora.Text = " Pregledaj filmove";
            this.Prozori.Controls.Clear();
            Pregledaj pregledaj = new Pregledaj()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(pregledaj);
            pregledaj.Show();
        }

        private void Iznajmi_Click(object sender, EventArgs e)
        {
            ImeProzora.Text = "Iznajmljivanje";
            this.Prozori.Controls.Clear();
            Iznajmi iznajmi = new Iznajmi()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(iznajmi);
            iznajmi.Show();
        }

        private void Vrati_Click(object sender, EventArgs e)
        {
            ImeProzora.Text = "Vraćanje";
            this.Prozori.Controls.Clear();
            Vrati vrati = new Vrati()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(vrati);
            vrati.Show();
        }
    }
}
