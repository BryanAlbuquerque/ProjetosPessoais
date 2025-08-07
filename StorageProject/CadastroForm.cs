using Microsoft.IdentityModel.Tokens;
using System;
using System.Windows.Forms;

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
    }
}
