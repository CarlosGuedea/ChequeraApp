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
    public partial class Detalle : Form
    {
        public static string busqueda;
        public static string detalle;

        public Detalle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalle = textBox1.Text;
            busqueda = "Detalle";
            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Dispose();
            busquedaGeneral.Show();
            busqueda = null;
        }
    }
}
