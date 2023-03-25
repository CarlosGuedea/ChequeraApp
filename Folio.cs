using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class Folio : Form
    {
        public static string busqueda;
        public static string folio;
        public Folio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Folio_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busqueda = "Folio";
            folio = textBox1.Text;
            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Dispose();
            busquedaGeneral.Show();
            folio = null;
        }
    }
}
