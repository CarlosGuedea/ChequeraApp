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
    public partial class Fecha : Form
    {
        public static string busqueda;
        public static string fecha;

        public Fecha()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            busqueda = "Fecha_Emision";
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");

            fecha = "'" + anio + "-" + mes + "-" + dia + "'";

            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Dispose();
            busquedaGeneral.Show();
            busqueda = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fecha_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fecha_FormClosing);
        }

        private void Fecha_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
            Buscar buscar = new Buscar();
            buscar.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
