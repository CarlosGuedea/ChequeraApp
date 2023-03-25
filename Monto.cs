using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class Monto : Form
    {
        public static string busqueda;
        public static string monto;

        public Monto()
        {
            InitializeComponent();
        }

        private void Monto_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monto = textBox1.Text;
            busqueda = "Monto";
            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Dispose();
            busquedaGeneral.Show();
            busqueda = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
