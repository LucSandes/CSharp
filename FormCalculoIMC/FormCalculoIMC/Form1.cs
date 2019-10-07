using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculoIMC_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = Convert.ToDouble(textoAltura.Text);
            peso = Convert.ToDouble(textoPeso.Text);

            imc = peso / Math.Pow(altura, 2);

            labelIMC.Text = imc.ToString();
            if (imc < 19)
            {
                labelSituacao.Text = "Abaixo do Peso";
            }
            else if (imc < 25)
            {
                labelSituacao.Text = "Peso Ideal";
            }
            else
            {
                labelSituacao.Text = "Acima do Peso";
            }
        }
    }
}
