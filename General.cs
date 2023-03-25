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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            llenaCampos();
        }

        private void General_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenaCampos()
        {
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Select * from Movimientos";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Limpiamos los campos
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["No_movimiento"].ToString(), reader["Fecha"].ToString(), reader["Monto"].ToString());
                }

                //Hacemos la verificación de las credenciales

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }
    }
}
