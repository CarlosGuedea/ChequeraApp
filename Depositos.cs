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
    public partial class Depositos : Form
    {
        public Depositos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");
            string Fecha = anio + "-" + mes + "-" + dia;
            string Monto = textBox2.Text.ToString();

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_RegistraMonto '" + Fecha + "'," + Monto;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                //Ejecutar la consulta
                MessageBox.Show(Sql);
                command.ExecuteNonQuery();

                //Limpiar campos
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void Depositos_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
