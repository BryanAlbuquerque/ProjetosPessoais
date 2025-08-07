using Microsoft.Data.SqlClient;
using System.Data;

namespace StorageProject
{
    public class GestaoConnect
    {
        // String para fazer a conexão com a DB
        private static string connectionString =
           "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=StorageDB;Trusted_Connection=True;TrustServerCertificate=true;";

        public DataTable CarregarDados()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Endereco, PalletID, DataEntrada, NomeInsumo, Fornecedor, Quantidade, ValorUnitario, ValorTotal, NumeroNotaFiscal, NumeroPedido, Consumo, QuantidadeAtual, RE_Colaborador FROM Gestao";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
