using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void btnGestao_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
            this.Hide();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.Show();
            this.Hide();
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            BaixaSistemica baixaSistema = new BaixaSistemica();
            baixaSistema.Show();    
            this.Hide();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco.Show();
            this.Hide();
        }
    }
}
