using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;
        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("Luccas");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new Conta();
            c2.Titular = new Cliente("Amanda");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new Conta();
            c3.Titular = new Cliente("Xovem");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            //comboContas.DataSource = contas;
            //comboContas.DisplayMember = "NomeTitularTratado";
            //comboContas.ValueMember = "Numero";

            //foreach (Conta conta in contas)
            //{
            //    comboContas.Items.Add(c.Titular.Nome);
            //}

        }

        private void TextoTitular_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            //string valorDigitado = textoValor.Text;
            //double valorOperacao = Convert.ToDouble(valorDigitado);
            //contas.Deposita(valorOperacao);
            //textoSaldo.Text = Convert.ToString(this.contas.Saldo);
            //MessageBox.Show("Sucesso!");

            int indice = Convert.ToInt32(comboContas.Text);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            //string valorDigitado = textoValor.Text;
            //double valorOperacao = Convert.ToDouble(valorDigitado);
            //this.contas.Saca(valorOperacao);
            //textoSaldo.Text = Convert.ToString(this.contas.Saldo);
            //MessageBox.Show("Sucesso!");

            int indice = Convert.ToInt32(comboContas.Text);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void ComboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void BotaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}
