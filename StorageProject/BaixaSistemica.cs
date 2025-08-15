using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StorageProject
{
    public partial class BaixaSistemica : Form
    {
        BaixasDB Baixas = new BaixasDB();
        public BaixaSistemica()
        {
            InitializeComponent();
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
            else if (BaixasDB.Baixas
                (PalletID,
                Quantidade))
            {
                MessageBox.Show("Baixa realizada!");
            }
        }
    }
}
