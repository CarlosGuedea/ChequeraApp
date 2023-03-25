using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SistemaControlChequesRev2
{


    public partial class PrincipalMenu : Form
    {
        public int exit;
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void btnExpedirCheque_Click(object sender, EventArgs e)
        {
            ExpedirCheque expedirCheque = Application.OpenForms.OfType<ExpedirCheque>().FirstOrDefault();
            if (expedirCheque == null)
            {
                expedirCheque = new ExpedirCheque();
                expedirCheque.Show();
            }
            else
            {
                MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque");
                expedirCheque.Focus();
            }
        }
        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            exit = 1;
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar buscar = Application.OpenForms.OfType<Buscar>().FirstOrDefault();
            if (buscar == null)
            {
                buscar = new Buscar();
                buscar.Show();
            }
            else
            {
                MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque");
                buscar.Focus();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (exit == 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("Terinando Programa");
                    Environment.Exit(0);
                }
            }
        }

        private void btnFolios_Click(object sender, EventArgs e)
        {
            Folios folios = Application.OpenForms.OfType<Folios>().FirstOrDefault();
            if (folios == null)
            {
                folios = new Folios();
                folios.Show();
            }
            else
            {
                MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque");
                folios.Focus();
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Depositos depositos = Application.OpenForms.OfType<Depositos>().FirstOrDefault();
            if (depositos == null)
            {
                depositos = new Depositos();
                depositos.Show();
            }
            else
            {
                MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque");
                depositos.Focus();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = Application.OpenForms.OfType<Reportes>().FirstOrDefault();
            if (reportes == null)
            {
                reportes = new Reportes();
                reportes.Show();
            }
            else
            {
                MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque5");
                reportes.Focus();
            }
        }
    }
}
