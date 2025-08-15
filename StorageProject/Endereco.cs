using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Endereco : Form
    {
        public Endereco()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtPL.Text);
            string Endereco = txtEnd.Text;


            if (string.IsNullOrEmpty(txtPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (EnderecoDB.Enderecamento(PalletID, Endereco))
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
