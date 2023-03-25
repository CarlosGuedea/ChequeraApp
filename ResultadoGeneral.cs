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
    public partial class ResultadoGeneral : Form
    {
        //Se recupera el tipo de consulta que se va a hacer
        string tipo;

        public ResultadoGeneral()
        {
            InitializeComponent();

            //Logica para saber que tipo se recuperó
            if (ReporteFolio.tipo != null)
            {
                tipo = ReporteFolio.tipo;
            }
            else if (ReporteNombre.tipo != null)
            {
                tipo = ReporteNombre.tipo;
            }
            else if (ReporteMonto.tipo != null)
            {
                tipo = ReporteMonto.tipo;
            }
            else if (ReporteDetalle.tipo != null)
            {
                tipo = ReporteDetalle.tipo;
            }
            else if (ReporteFecha.tipo != null)
            {
                tipo = ReporteFecha.tipo;
            }

            llenaCampos();
        }

        private void ResultadoGeneral_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llenaCampos()
        {
            //Se recuperan los valores
            string Folio1 = ReporteFolio.RepoFolio1;
            string Folio2 = ReporteFolio.RepoFolio2;
            string RepoNombre = ReporteNombre.RepoNombre;
            string RepoMonto1 = ReporteMonto.RepoMonto1;
            string RepoMonto2 = ReporteMonto.RepoMonto2;
            string Detalle = ReporteDetalle.RepoDetalle;
            string Fecha1 = ReporteFecha.Fecha1;
            string Fecha2 = ReporteFecha.Fecha2;

            //MessageBox.Show(tipo);

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                switch (tipo)
                {
                    case "Folio":
                        String Sql = "Exec sp_ReporteFolio " + Folio1 + "," + Folio2;
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
                            dataGridView1.Rows.Add(reader["Folio"].ToString(), reader["Nombre"].ToString(), reader["Monto"].ToString(), reader["Fecha_Emision"].ToString(), reader["Detalle"].ToString());
                        }
                        break;
                    case "Beneficiario":
                        String Sql2 = "Select * from Cheque where " + tipo + " like " + "'%" + RepoNombre + "%'";
                        SqlCommand command2 = new SqlCommand(Sql2, conexion);
                        command2.CommandType = System.Data.CommandType.Text;
                        SqlDataReader reader2;
                        conexion.Open();

                        //Ejecutar la consulta
                        reader2 = command2.ExecuteReader();

                        //Limpiamos los campos
                        dataGridView1.Rows.Clear();

                        //Recorremos el objeto reader
                        while (reader2.Read())
                        {
                            dataGridView1.Rows.Add(reader2["Folio"].ToString(), reader2["Beneficiario"].ToString(), reader2["Monto"].ToString(), reader2["Fecha_Emision"].ToString(), reader2["Detalle"].ToString());
                        }
                        break;
                    case "Monto":
                        String Sql3 = "Select * from Cheque where " + tipo + " between " + RepoMonto1 + " and " + RepoMonto2;
                        SqlCommand command3 = new SqlCommand(Sql3, conexion);
                        command3.CommandType = System.Data.CommandType.Text;
                        SqlDataReader reader3;
                        conexion.Open();

                        //Ejecutar la consulta
                        reader3 = command3.ExecuteReader();

                        //Limpiamos los campos
                        dataGridView1.Rows.Clear();

                        //Recorremos el objeto reader
                        while (reader3.Read())
                        {
                            dataGridView1.Rows.Add(reader3["Folio"].ToString(), reader3["Beneficiario"].ToString(), reader3["Monto"].ToString(), reader3["Fecha_Emision"].ToString(), reader3["Detalle"].ToString());
                        }
                        break;
                    case "Fecha_Emision":
                        String Sql4 = "Select * from Cheque where " + tipo + " between " + Fecha1 + " and " + Fecha2;
                        SqlCommand command4 = new SqlCommand(Sql4, conexion);
                        command4.CommandType = System.Data.CommandType.Text;
                        SqlDataReader reader4;
                        conexion.Open();

                        //Ejecutar la consulta
                        reader4 = command4.ExecuteReader();

                        //Limpiamos los campos
                        dataGridView1.Rows.Clear();

                        //Recorremos el objeto reader
                        while (reader4.Read())
                        {
                            dataGridView1.Rows.Add(reader4["Folio"].ToString(), reader4["Beneficiario"].ToString(), reader4["Monto"].ToString(), reader4["Fecha_Emision"].ToString(), reader4["Detalle"].ToString());
                        }
                        break;
                    case "Detalle":
                        String Sql5 = "Select * from Cheque where " + tipo + " like " + "'%" + Detalle + "%'";
                        SqlCommand command5 = new SqlCommand(Sql5, conexion);
                        command5.CommandType = System.Data.CommandType.Text;
                        SqlDataReader reader5;
                        conexion.Open();

                        //Ejecutar la consulta
                        reader5 = command5.ExecuteReader();

                        //Limpiamos los campos
                        dataGridView1.Rows.Clear();

                        //Recorremos el objeto reader
                        while (reader5.Read())
                        {
                            dataGridView1.Rows.Add(reader5["Folio"].ToString(), reader5["Beneficiario"].ToString(), reader5["Monto"].ToString(), reader5["Fecha_Emision"].ToString(), reader5["Detalle"].ToString());
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
