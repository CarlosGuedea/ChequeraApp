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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaControlChequesRev2
{
    public partial class ExpedirCheque : Form
    {
        public int estado;
        public ExpedirCheque()
        {
            InitializeComponent();
            estado = 0;

            //LLENAR EL COMBOBOX DE NOMBRE AL INICIO DEL WINDOWS FORMS
            combNombreFill();

            //LLENAR EL COMBOBOX DE DETALLE AL INICIO DE WINDOWS FORMS
            combConceptoFill();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            estado -= 1;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Folio = this.com.Text;
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");
            string Fecha = "'" + anio + "-" + mes + "-" + dia + "'";
            string Nombre = this.combNombre.Text;
            string Monto = this.Monto.Text;
            string Detalle = this.combConcepto.Text;
            
            
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_ExpedirCheque " + Nombre +","+ Monto +","+Fecha+","+Detalle;
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

            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btbNuevoBeneficiario_Click(object sender, EventArgs e)
        {
            AgregarBeneficiario agregarBeneficiario = new AgregarBeneficiario();
            agregarBeneficiario.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            AgregarConcepto agregarConcepto = new AgregarConcepto();
            agregarConcepto.Show();
        }
        private int salir;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                salir = 1;
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string Folio = this.com.Text;
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");
            string Fecha = "'" + anio + "-" + mes + "-" + dia + "'";
            string Nombre = this.combNombre.SelectedItem.ToString();
            string Monto = this.Monto.Text;
            string Detalle = this.combConcepto.SelectedItem.ToString();

            MessageBox.Show(Detalle);

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_ExpedirCheque " + "'"+ Nombre + "'," + Monto + "," + Fecha + "," + "'"+Detalle+"'";
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

            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Close();
        }

        private void ExpedirCheque_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
        }

        private void combNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        //METODO PARA LLENAR EL COMBOBOX DE NOMBRE AL INICIO
        private void combNombreFill()
        {
            //Conección a la base de datos
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

            String Sql = "Select Nombre from Beneficiario";
            SqlCommand command = new SqlCommand(Sql, conexion);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader;
            conexion.Open();

            //Ejecutar la consulta
            reader = command.ExecuteReader();


            //Recorremos el objeto reader
            while (reader.Read())
            {
                combNombre.Items.Add(reader.GetString(0));
            }
        }

        //METODO PARA LLENAR EL COMBOBOX DE DETALLE
        private void combConceptoFill()
        {
            //Conección a la base de datos
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

            String Sql = "Select Detalle from Detalle_Cheque";
            SqlCommand command = new SqlCommand(Sql, conexion);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader;
            conexion.Open();

            //Ejecutar la consulta
            reader = command.ExecuteReader();


            //Recorremos el objeto reader
            while (reader.Read())
            {
                combConcepto.Items.Add(reader.GetString(0));
            }
        }
    }
}
