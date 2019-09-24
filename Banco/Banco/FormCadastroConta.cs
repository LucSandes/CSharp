using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
        }

        private void BotaoCadastro_Click(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
