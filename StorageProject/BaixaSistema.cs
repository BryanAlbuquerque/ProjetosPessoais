using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StorageProject
{
    public partial class BaixaSistema : Form
    {
        public BaixaSistema()
        {
            InitializeComponent();
        }

        internal class BaixaSistemica
        {
            private static string connectionString =
                "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=StorageDB;Trusted_Connection=True;TrustServerCertificate=true";

            public static bool Decrease(int PalletID, int quantidade)
            {
                using (var conexao = new SqlConnection(connectionString)) // Variavel que chama a conexão acima
                {
                    string query = @"
                    UPDATE Gestao
                    SET 
                        QuantidadeAtual = 
                    CASE 
                        WHEN QuantidadeAtual IS NULL THEN Quantidade - @quantidade
                        ELSE QuantidadeAtual - @quantidade
                        END,
                    Consumo = 
                        ISNULL(Consumo, 0) + @quantidade
                         WHERE PalletID = @palletId";


                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@palletId", PalletID);
                        comando.Parameters.AddWithValue("@quantidade", quantidade);

                        try
                        {
                            conexao.Open();
                            int rowsAffected = comando.ExecuteNonQuery();

                            if (rowsAffected > 0)
                                return true;
                            else
                            {
                                Console.WriteLine("Nenhum registro foi atualizado.");
                                return false;
                            }
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("Erro ao atualizar dados: " + ex.Message);
                            return false;
                        }

                    }
                }

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtPl.Text);
            int Quantidade = int.Parse(txtQtde.Text);

            if (string.IsNullOrEmpty(txtPl.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (BaixaSistemica.Decrease
                (PalletID,
                Quantidade))
            {
                MessageBox.Show("Baixa realizada!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
