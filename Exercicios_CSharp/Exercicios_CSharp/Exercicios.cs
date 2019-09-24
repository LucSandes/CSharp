using System;
using System.Windows.Forms;

namespace Exercicios_CSharp
{
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 12;
            int c = 13;
            double delta, a1, a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("O delta é " + delta + "O a1 é " + a1 + "E o a2 é " + a2);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int idade = 18;
            bool brasileira = false;

            if((idade > 16) && (brasileira == true))
            {
                MessageBox.Show("Está apta para votar");
            }
            else
            {
                MessageBox.Show("Não está apta para votar");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 500;
            double imposto;
            double valorPago;

            if (valorDaNotaFiscal <= 999)
            {
                imposto = 0.02;
                valorPago = valorDaNotaFiscal * imposto;
                MessageBox.Show("Imposto é de: " + valorPago);
            }
            else if (valorDaNotaFiscal <= 2999)
            {
                imposto = 0.025;
                valorPago = valorDaNotaFiscal * imposto;
                MessageBox.Show("Imposto é de: " + valorPago);
            }
            else if (valorDaNotaFiscal <= 6999)
            {
                imposto = 0.028;
                valorPago = valorDaNotaFiscal * imposto;
                MessageBox.Show("Imposto é de: " + valorPago);
            }
            else
            {
                imposto = 0.03;
                valorPago = valorDaNotaFiscal * imposto;
                MessageBox.Show("Imposto é de: " + valorPago);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int valor = 15;  valor > 10; valor++)
            {
                mensagem = "Maior que 10!";
            }
            
            MessageBox.Show(mensagem);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000;
            int i = 1;
            while (i <= 12)
            {
                valorInvestido = valorInvestido + 1.01;
                i += 1;
            }
            MessageBox.Show("O valor investido é " + valorInvestido);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000;
            int i = 1;

            do
            {
                valorInvestido = valorInvestido + 1.01;
                i += 1;
            }
            while (i <= 12);
            MessageBox.Show("O valor investido é " + valorInvestido);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("O múltiplo de 3 é: " + i);

                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo(100);
            c.        }
    }
}
