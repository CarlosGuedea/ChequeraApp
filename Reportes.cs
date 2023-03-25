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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó un valor en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Verificar qué opción se seleccionó en el ComboBox
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Cheques":
                        // Abrir el formulario correspondiente para "Nombre"
                        ResultadoCheques resultadoCheques = Application.OpenForms.OfType<ResultadoCheques>().FirstOrDefault();
                        if (resultadoCheques == null)
                        {
                            resultadoCheques = new ResultadoCheques();
                            this.Close();
                            resultadoCheques.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para generar un reporte de cheque nuevo");
                            resultadoCheques.Focus();
                        }
                        break;
                    case "Estado de cuenta":
                        // Abrir el formulario correspondiente para "Nombre"
                        General general = Application.OpenForms.OfType<General>().FirstOrDefault();
                        if (general == null)
                        {
                            general = new General();
                            this.Close();
                            general.Show();

                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para generar un nuevo reporte de Estado de cuenta");
                            general.Focus();
                        }
                        break;
                    case "General":
                        // Abrir el formulario correspondiente para "Nombre"
                        EstadoDecuenta estadoDeCuenta = Application.OpenForms.OfType<EstadoDecuenta>().FirstOrDefault();
                        if (estadoDeCuenta == null)
                        {
                            estadoDeCuenta = new EstadoDecuenta();
                            this.Close();
                            estadoDeCuenta.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para un nuevo Reporte General");
                            estadoDeCuenta.Focus();
                        }
                        break;

                    case "Busquedas Anidadas":
                        // Abrir el formulario correspondiente para "Nombre"
                        BusquedaAnidada busquedaAnidada = Application.OpenForms.OfType<BusquedaAnidada>().FirstOrDefault();
                        if (busquedaAnidada == null)
                        {
                            busquedaAnidada = new BusquedaAnidada();
                            this.Close();
                            busquedaAnidada.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para un nuevo Reporte General");
                            busquedaAnidada.Focus();
                        }
                        break;
                    default:
                        // Mostrar un mensaje de error si no se seleccionó una opción válida
                        MessageBox.Show("Por favor seleccione una opción válida.");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una opción válida.");
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
