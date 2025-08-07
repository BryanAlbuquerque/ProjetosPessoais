using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class BaixaSistema : Form
    {
        public BaixaSistema()
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
            int RE = int.Parse(txtRE.Text);
            int PalletID = int.Parse(txtPl.Text);
            int Quantidade = int.Parse(txtQtde.Text);

            if (string.IsNullOrEmpty(txtPl.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (BaixaSistemica.Calculo
                (RE,
                PalletID,
                Quantidade))
            {
                MessageBox.Show("Baixa realizada!");
            }
        }
    }
}
