using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;


namespace StorageProject
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        public class Input
        {
            private static string connectionString =
                "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=StorageDB;Trusted_Connection=True;TrustServerCertificate=true;";

            // Método para inserir dados na tabela Gestao
            public static bool Entrada(
                DateTime dataEntrada,
                string nome,
                string fornecedor,
                int quantidade,
                string valorUnitario,
                string valorTotal,
                int numeroNotaFiscal,
                string numeroPedido,
                int PLID,
                int reColab
                )

            {
                // Query que joga as informações na DB
                using (var conexao = new SqlConnection(connectionString))
                {
                    string query = @"
                    INSERT INTO Gestao 
                    (DataEntrada, NomeInsumo, Fornecedor, Quantidade, ValorUnitario, ValorTotal, NumeroNotaFiscal, NumeroPedido, PalletID, RE_Colaborador)
                    VALUES 
                    (@dataEntrada, @nome, @fornecedor, @quantidade, @valorUnitario, @valorTotal, @numeroNotaFiscal, @numeroPedido, @PalletID, @reColab)";

                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@dataEntrada", dataEntrada);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@fornecedor", fornecedor);
                        comando.Parameters.AddWithValue("@quantidade", quantidade);
                        comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                        comando.Parameters.AddWithValue("@valorTotal", valorTotal);
                        comando.Parameters.AddWithValue("@numeroNotaFiscal", numeroNotaFiscal);
                        comando.Parameters.AddWithValue("@numeroPedido", numeroPedido);
                        comando.Parameters.AddWithValue("@PalletID", PLID);
                        comando.Parameters.AddWithValue("@reColab", reColab);

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

            DateTime dataEntrada = dtData.Value;
            string nome = txtNome.Text;
            string fornecedor = txtForn.Text;
            int quantidade = int.Parse(txtQtde.Text);

            string valorUnitario = txtValorUni.Text.ToString();
            string valorTotal = txtValor.Text.ToString();

            int numeroNotaFiscal = int.Parse(txtNF.Text);
            string numeroPedido = txtNP.Text.ToString();
            int PLID = int.Parse(txtPL.Text);
            int reColab = int.Parse(txtREColab.Text);



            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Erro! Existem espaços em branco!");
            }
            else if (Input.Entrada(
            dataEntrada,
            nome,
            fornecedor,
            quantidade,
            valorUnitario,
            valorTotal,
            numeroNotaFiscal,
            numeroPedido,
            PLID,
            reColab))
            {
                MessageBox.Show("Entrada realizado com sucesso!");
            }

            if (txtNP.Text.Length > 10)
            {
                MessageBox.Show("Permitido Somente 10 Caracteres!");
            }

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Today.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();

        }
    }
}
