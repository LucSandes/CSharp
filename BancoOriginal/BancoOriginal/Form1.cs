using System;
using System.Windows.Forms;

namespace BancoOriginal
{
    public partial class Form1 : Form
    {
        private Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("Luccas");
            c.Titular = cliente;
            this.conta = new Conta();

            //ContaPoupanca c = new ContaPoupanca();
            //ContaPoupanca conta = new ContaPoupanca("Luccas");
            //c.Deposita(100.0);
            //c.Saca(50);

            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Depositado com sucesso!");
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sacado com sucesso!");
        }
    }
}
