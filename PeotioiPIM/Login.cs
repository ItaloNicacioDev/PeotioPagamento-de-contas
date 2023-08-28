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
using System.Data.SqlClient;

namespace PeotioiPIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=KAZAMA;Initial Catalog=LoginPim;Integrated Security=True";
        private void btnAvançar_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtSenha.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login bem-sucedido!");
                // Aqui você pode abrir a próxima janela ou executar outras ações após o login bem-sucedido
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog();
                this.Close(); // Esconde o formulário de login
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Username = @username AND Password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           Inicio   inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
    
}
