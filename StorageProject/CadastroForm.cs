using Microsoft.IdentityModel.Tokens;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StorageProject
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        //Evento que realiza o cadastro a partir do (UserStorage)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            int re = int.Parse(txtRE.Text);

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Erro! Existem espaços em branco!");
            }
            else if (UserStorage.CadastrarUsuario(usuario, senha, re))
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            }
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";   
        }

        private void txtRE_MouseClick(object sender, MouseEventArgs e)
        {
            txtRE.Text = "";
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
