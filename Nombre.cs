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
    public partial class Nombre : Form
    {
        //Recuperar la variable
        public static string nombre;
        public static string busqueda;

        public Nombre()
        {
            InitializeComponent();
        }

        private void Nombre_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario

            Buscar buscar = new Buscar();
            buscar.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BuscaNombre = txtBuscaNombre.Text;
            busqueda = "Beneficiario";
            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Dispose();
            busquedaGeneral.Show();
            busqueda = null;
        }
    }
}
