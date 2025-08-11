using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           string email = txtEmail.Text;
           int senha = int.Parse(txtSenha.Text);

            if (UserStorage.AutenticarADM(email, senha))
            {
                TelaPrincipal principal = new TelaPrincipal();
                principal.Show();
                this.Hide();
            }
        }
    }
}
