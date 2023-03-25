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
    public partial class ReporteMonto : Form
    {
        public static string RepoMonto1;
        public static string RepoMonto2;
        public static string tipo;
        public ReporteMonto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepoMonto1 = textBox1.Text.ToString();
            RepoMonto2 = textBox2.Text.ToString();
            tipo = "Monto";
            ResultadoGeneral resultadoGeneral = new ResultadoGeneral();
            tipo = null;
            this.Close();
            resultadoGeneral.Show();
        }

        private void ReporteMonto_Load(object sender, EventArgs e)
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
