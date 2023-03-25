using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaControlChequesRev2
{
    public partial class Buscar : Form
    {
        private int salir;
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                salir = 1;
                this.Close();
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó un valor en el ComboBox
            if (cbxBuscar.SelectedItem != null)
            {
                // Verificar qué opción se seleccionó en el ComboBox
                switch (cbxBuscar.SelectedItem.ToString())
                {
                    case "Nombre":
                        // Abrir el formulario correspondiente para "Nombre"
                        Nombre nombre = Application.OpenForms.OfType<Nombre>().FirstOrDefault();
                        if (nombre == null)
                        {
                            nombre = new Nombre();
                            this.Hide();
                            nombre.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para Expedir un nuevo Chequfgfffe");
                            nombre.Focus();
                        }
                        break;
                    case "Fecha":
                        // Abrir el formulario correspondiente para "Nombre"
                        Fecha fecha = Application.OpenForms.OfType<Fecha>().FirstOrDefault();
                        if (fecha == null)
                        {
                            fecha = new Fecha();
                            this.Hide();
                            fecha.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para Expedir un nuevo Chequfgfffe");
                            fecha.Focus();
                        }
                        break;
                    case "Monto":
                        // Abrir el formulario correspondiente para "Nombre"
                        Monto monto = Application.OpenForms.OfType<Monto>().FirstOrDefault();
                        if (monto == null)
                        {
                            monto = new Monto();
                            this.Hide();
                            monto.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para Expedir un nuevo Chequfgfffe");
                            monto.Focus();
                        }
                        break;
                    case "Detalle":
                        // Abrir el formulario correspondiente para "Nombre"
                        Detalle detalle = Application.OpenForms.OfType<Detalle>().FirstOrDefault();
                        if (detalle == null)
                        {
                            detalle = new Detalle();
                            this.Hide();
                            detalle.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para Expedir un nuevo Chequfgfffe");
                            detalle.Focus();
                        }
                        break;
                    case "Folio":
                        // Abrir el formulario correspondiente para "Nombre"
                        Folio folio = Application.OpenForms.OfType<Folio>().FirstOrDefault();
                        if (folio == null)
                        {
                            folio = new Folio();
                            this.Hide();
                            folio.Show();
                        }
                        else
                        {
                            MessageBox.Show("Termine proceso actual para Expedir un nuevo Cheque");
                            folio.Focus();
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

        private void Buscar_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buscar_FormClosing);
        }

        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Crear una lista auxiliar con las referencias a los formularios a cerrar
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form is Buscar || form is Nombre || form is Fecha || form is Monto || form is Detalle || form is Folio)
                {
                    formsToClose.Add(form);
                }
            }

            // Iterar sobre la lista auxiliar y cerrar los formularios
            foreach (Form form in formsToClose)
            {
                form.Dispose();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                salir = 1;
                this.Close();
            }
        }
    }
}
