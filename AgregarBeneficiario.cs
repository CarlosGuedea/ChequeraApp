using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class AgregarBeneficiario : Form
    {
        public AgregarBeneficiario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            int salir;
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                salir = 1;
                this.Close();
            }
        }

        private void AgregarBeneficiario_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Recuperar los valores
            string Nombre = textBox1.Text;

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Insert into Beneficiario (Nombre) values ('" + Nombre + "')";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                //Ejecutar la consulta
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }

            this.Close();
        }
    }

}