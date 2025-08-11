using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Endereco : Form
    {
        public Endereco()
        {
            InitializeComponent();
        }

        internal class Addressing
        {
            private static string connectionString =
                 "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=StorageDB;Trusted_Connection=True;TrustServerCertificate=true;";

            public static bool Address(int PalletID, string endereco)
            {
                using (var conexao = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Gestao
                        SET Endereco = @endereco
                        WHERE PalletID = @PalletID";


                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@palletId", PalletID);
                        comando.Parameters.AddWithValue("@endereco", endereco);


                        try
                        {
                            conexao.Open();
                            comando.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtPL.Text);
            string Endereco = txtEnd.Text;


            if (string.IsNullOrEmpty(txtPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (Addressing.Address(PalletID, Endereco))
            {
                MessageBox.Show("Endereçamento Realizado!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }
    }
}
