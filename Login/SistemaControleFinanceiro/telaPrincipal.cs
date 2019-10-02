using System;
using System.Windows.Forms;

namespace SistemaControleFinanceiro
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Luccas";
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)//BotaoConta
        {
            if (textoConta.Text == "admin")
            {

                ContaCliente contaCliente = new ContaCliente();
                contaCliente.ShowDialog();

            }
            else if (textoConta = valorDigitado)
            {

            }
            else if (textoConta.Text == "")
            {
                MessageBox.Show("Digite o nome de alguma conta!");
            }
            else
            {
                MessageBox.Show("Não existe essa conta");
            }

        }

        private void TextoConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
