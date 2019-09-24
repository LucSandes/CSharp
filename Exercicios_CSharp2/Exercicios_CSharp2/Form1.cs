using System;
using System.Windows.Forms;

namespace Exercicios_CSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Victor Harada")
            {
                cpf = "123.456.789-01";
                rg = "21.345.987-x";
                idade = 25;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Numero = 1;
            MessageBox.Show("numero: " + c.Numero);

        }
    }
}
