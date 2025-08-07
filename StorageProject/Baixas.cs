using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace StorageProject
{
    internal class BaixaSistemica
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=StorageDB;Trusted_Connection=True;TrustServerCertificate=true";

        public static bool Calculo(int RE, int PalletID, int Quantidade)
        {
            using (var conexao = new SqlConnection(connectionString)) // Variavel que chama a conexão acima
            {
                string query = @"INSERT INTO Gestao
                    (RE, PalletID, quantidade)
                    VALUES
                    (@re, @palletId, @quantidade)";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@re", RE);
                    comando.Parameters.AddWithValue("@palletId", PalletID);
                    comando.Parameters.AddWithValue("@quantidade", Quantidade);


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
}
