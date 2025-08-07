using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Gestao : Form
    {

        private GestaoConnect gestao = new GestaoConnect();
        public Gestao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
            this.Hide();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            dataGridGestao.AutoGenerateColumns = false;
            dataGridGestao.DataSource = gestao.CarregarDados();

        }
    }
}

