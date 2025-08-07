using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Evento que faz o login Usando o Atutenticas do (User Storage)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            int re = int.Parse(txtRE.Text);

            if (UserStorage.Autenticar(usuario, senha, re))
            {
                TelaPrincipal tela = new TelaPrincipal();
                tela.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario ou senha incorretos!");
            }

        }

        //Evento que direciona a tela de cadastro
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();
            cadastro.Show();
            this.Hide();
        }
    }
}
