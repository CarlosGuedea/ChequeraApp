using System.Data.SqlClient;

namespace SistemaControlChequesRev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Hide();
            principalMenu.ShowDialog();/*
            //Obtener los datos del front-end
            String Usuario = txtUser.Text;
            String Contraseña = txtPass.Text;

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Select * from Usuario";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    String User = reader.GetString(reader.GetOrdinal("Nombre"));
                    String Clave = reader.GetString(reader.GetOrdinal("Contrasena"));

                    // Aquí se realizaría la validación de las credenciales de usuario
                    if (Usuario == User && Clave == Contraseña)
                    {
                        // Si las credenciales son correctas, se abre una nueva ventana
                        PrincipalMenu principalMenu = new PrincipalMenu();
                        this.Hide();
                        principalMenu.ShowDialog();
                    }
                    else
                    {
                        // Si las credenciales son incorrectas, se muestra un mensaje de error
                        MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
                    }
                }

                //Hacemos la verificación de las credenciales

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }*/
        }
    }
}