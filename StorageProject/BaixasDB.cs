using System;
using Microsoft.Data.SqlClient;

namespace StorageProject
{
    internal class BaixasDB
    {
        private static string connectionString =
                "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=Storage;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool Baixas(int PalletID, int quantidade)
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

}

