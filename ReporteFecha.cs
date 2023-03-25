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
    public partial class ReporteFecha : Form
    {
        public static string tipo;
        public static string Fecha1;
        public static string Fecha2;
        public ReporteFecha()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            tipo = "Fecha_Emision";
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");

            Fecha1 = "'" + anio + '-' + mes + "-" + dia + "'";

            string dia2 = dateTimePicker1.Value.ToString("dd");
            string mes2 = dateTimePicker1.Value.ToString("MM");
            string anio2 = dateTimePicker1.Value.ToString("yyyy");
            Fecha2 = "'" + anio2 + '-' + mes2 + "-" + dia2 + "'";

            ResultadoGeneral resultadoGeneral = new ResultadoGeneral();
            resultadoGeneral.Show();
            tipo = null;
            this.Dispose();
        }

        private void ReporteFecha_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            EstadoDecuenta estadoDecuenta = new EstadoDecuenta();
            estadoDecuenta.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
