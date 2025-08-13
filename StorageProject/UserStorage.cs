using Microsoft.Data.SqlClient;
using System;

namespace StorageProject
{
    internal class UserStorage
    {
        // String para fazer a conexão com a DB
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true;";

        // Metodo que faz as Query e a Parte lógica de conexão e cadastro usuário
        public static bool CadastrarUsuario(string usuario, string senha, int re)
        {
            using (var conexao = new SqlConnection(connectionString)) // Variavel que chama a conexão acima
            {
                //Query que joga as informações no SQL Server
                string query = "INSERT INTO Usuarios (Usuario, Senha, RE_Colaborador) VALUES (@usuario, @senha, @re)";
                var comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@re", re);

                conexao.Open();
                try
                {
                    comando.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Usuário duplicado
                        return false;
                    throw;
                }
            }
        }

        //Metodo usada para autenticar e fazer o login
        public static bool Autenticar(string usuario, string senha)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Senha = @senha";
                var comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                int resultado = (int)comando.ExecuteScalar(); // Comando usado para fazer consulta o SQLServer
                return resultado > 0;
            }
        }

        public static bool AutenticarADM(string email, int senha)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Admins WHERE Email_Admin = @email AND Senha = @senha";
                var comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                int resultado = (int)comando.ExecuteScalar();
                return resultado > 0; // Retorna true se encontrar registro
            }
        }
    }
}