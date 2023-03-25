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
    public partial class EstadoDecuenta : Form
    {
        public EstadoDecuenta()
        {
            InitializeComponent();
        }

        private void EstadoDecuenta_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario

            Reportes Reportes = new Reportes();
            Reportes.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // Verificar qué opción se seleccionó en el ComboBox
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Folio":
                        // Abrir el formulario correspondiente para "Nombre"
                        ReporteFolio reporteFolio = Application.OpenForms.OfType<ReporteFolio>().FirstOrDefault();
                        if (reporteFolio == null)
                        {
                            reporteFolio = new ReporteFolio();
                            this.Hide();
                            reporteFolio.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para generar un reporte de cheque nuevo");
                            reporteFolio.Focus();
                        }
                        break;
                    case "Monto":
                        // Abrir el formulario correspondiente para "Nombre"
                        ReporteMonto reporteMonto = Application.OpenForms.OfType<ReporteMonto>().FirstOrDefault();
                        if (reporteMonto == null)
                        {
                            reporteMonto = new ReporteMonto();
                            this.Hide();
                            reporteMonto.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para generar un nuevo reporte de Estado de cuenta");
                            reporteMonto.Focus();
                        }
                        break;
                    case "Fecha":
                        // Abrir el formulario correspondiente para "Nombre"
                        ReporteFecha reporteFecha = Application.OpenForms.OfType<ReporteFecha>().FirstOrDefault();
                        if (reporteFecha == null)
                        {
                            reporteFecha = new ReporteFecha();
                            this.Hide();
                            reporteFecha.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para un nuevo Reporte por Fecha");
                            reporteFecha.Focus();
                        }
                        break;
                    case "Detalle":
                        // Abrir el formulario correspondiente para "Nombre"
                        ReporteDetalle reporteDetalle = Application.OpenForms.OfType<ReporteDetalle>().FirstOrDefault();
                        if (reporteDetalle == null)
                        {
                            reporteDetalle = new ReporteDetalle();
                            this.Hide();
                            reporteDetalle.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para un nuevo Reporte por Detalle");
                            reporteDetalle.Focus();
                        }
                        break;

                    case "Nombre":
                        // Abrir el formulario correspondiente para "Nombre"
                        ReporteNombre reporteNombre = Application.OpenForms.OfType<ReporteNombre>().FirstOrDefault();
                        if (reporteNombre == null)
                        {
                            reporteNombre = new ReporteNombre();
                            this.Hide();
                            reporteNombre.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para un nuevo Reporte Por Nombre");
                            reporteNombre.Focus();
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
    }
}
