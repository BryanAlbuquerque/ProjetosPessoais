using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Gestao : Form
    {

        private ConnectionManagement CN = new ConnectionManagement();
        public Gestao()
        {
            InitializeComponent();
        }

        //Classe para fazer conexão com a DataBase
        public class ConnectionManagement
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

        private void Gestao_Load(object sender, EventArgs e)
        {
            dataGridGestao.AutoGenerateColumns = false;
            dataGridGestao.DataSource = CN.CarregarDados();

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }
    }
}

