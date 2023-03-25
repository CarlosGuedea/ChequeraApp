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
    public partial class ReporteFolio : Form
    {
        public static string RepoFolio1;
        public static string RepoFolio2;
        public static string tipo;
        public ReporteFolio()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            tipo = "Folio";
            RepoFolio1 = textBox1.Text;
            RepoFolio2 = textBox2.Text;

            ResultadoGeneral resultadoGeneral = new ResultadoGeneral();
            resultadoGeneral.Show();
            tipo = null;
            this.Dispose();
        }

        private void ReporteFolio_Load(object sender, EventArgs e)
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