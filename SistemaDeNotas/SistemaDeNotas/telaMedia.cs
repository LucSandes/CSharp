using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaMedia : Form
    {
        public telaMedia()
        {
            InitializeComponent();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;//limparTextBoxes(this.Controls);
                }
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            //textoNota1.Text = String.Empty;
            //textoNota2.Text = String.Empty;
            //textoNota3.Text = String.Empty;
            //textoNota4.Text = String.Empty;
            //textoMedia.Text = String.Empty;
            //textoMenor.Text = String.Empty;
            //textoMaior.Text = String.Empty;
        }

        private void BotaoMedia_Click(object sender, EventArgs e)
        {
            double media, nota1, nota2, nota3, nota4, notaMaior, notaMenor;

            nota1 = Convert.ToDouble(textoNota1.Text);
            nota2 = Convert.ToDouble(textoNota2.Text);
            nota3 = Convert.ToDouble(textoNota3.Text);
            nota4 = Convert.ToDouble(textoNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            textoMedia.Text = Convert.ToString(media);


            if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
            {
                notaMaior = nota1;
                textoMaior.Text = Convert.ToString(notaMaior);
            }
            else if (nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
            {
                notaMaior = nota2;
                textoMaior.Text = Convert.ToString(notaMaior);
            }
            else if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
            {
                notaMaior = nota3;
                textoMaior.Text = Convert.ToString(notaMaior);
            }
            else
                notaMaior = nota4;
                textoMaior.Text = Convert.ToString(notaMaior);

            if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
            {
                notaMenor = nota1;
                textoMenor.Text = Convert.ToString(notaMenor);
            }
            else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
            {
                notaMenor = nota2;
                textoMenor.Text = Convert.ToString(notaMenor);
            }
            else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
            {
                notaMenor = nota3;
                textoMenor.Text = Convert.ToString(notaMenor);
            }
            else
                notaMenor = nota4;
                textoMenor.Text = Convert.ToString(notaMenor);
        }

        private void TextoMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaMedia_Load(object sender, EventArgs e)
        {

        }
    }
}
