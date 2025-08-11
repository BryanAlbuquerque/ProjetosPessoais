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

            if (UserStorage.Autenticar(usuario, senha))
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
