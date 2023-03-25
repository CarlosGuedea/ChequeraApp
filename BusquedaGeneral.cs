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
    public partial class BusquedaGeneral : Form
    {
        string busqueda;
        public BusquedaGeneral()
        {
            //Logica para saber que tipo se recuperó
            if (SistemaControlChequesRev2.Folio.busqueda != null)
            {
                busqueda = SistemaControlChequesRev2.Folio.busqueda;
            }
            else if (Nombre.busqueda != null)
            {
                busqueda = Nombre.busqueda;
            }
            else if (SistemaControlChequesRev2.Monto.busqueda != null)
            {
                busqueda = SistemaControlChequesRev2.Monto.busqueda;
            }
            else if (SistemaControlChequesRev2.Detalle.busqueda != null)
            {
                busqueda = SistemaControlChequesRev2.Detalle.busqueda;
            }
            else if (Fecha.busqueda != null)
            {
                busqueda = SistemaControlChequesRev2.Fecha.busqueda;
            }

            InitializeComponent();
            llenaCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BusquedaGeneral_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            Buscar buscar = new Buscar();
            buscar.Show();
            this.Dispose();
        }

        private void llenaCampos()
        {
            //Se recuperan los valores
            string Folio1 = SistemaControlChequesRev2.Folio.folio;
            string Nombre1 = Nombre.nombre;
            string Monto1 = SistemaControlChequesRev2.Monto.monto;
            string Detalle1 = SistemaControlChequesRev2.Detalle.detalle;
            string Fecha1 = Fecha.fecha;


            //MessageBox.Show(busqueda);

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                switch (busqueda)
                {
                    case "Folio":
                        String Sql = "Select * from Cheque where " + busqueda + " = " + Folio1; ;
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
                            dataGridView1.Rows.Add(reader["Folio"].ToString(), reader["Beneficiario"].ToString(), reader["Monto"].ToString(), reader["Fecha_Emision"].ToString(), reader["Detalle"].ToString());
                        }
                        break;
                    case "Beneficiario":
                        String Sql2 = "Select * from Cheque where " + busqueda + " like " + "'%" + Nombre1 + "%'";
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
                        String Sql3 = "Select * from Cheque where " + busqueda + " = " + Monto1;
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
                        String Sql4 = "Select * from Cheque where " + busqueda + " = " + Fecha1;
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
                        String Sql5 = "Select * from Cheque where " + busqueda + " like " + "'%" + Detalle1 + "%'";
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


    }
}
