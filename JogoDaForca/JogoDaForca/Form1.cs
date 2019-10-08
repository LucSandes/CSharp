using System;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class formJogoDaForca : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;

        public formJogoDaForca()
        {
            InitializeComponent();
            this.IniciaVetor();
        }

        private void IniciaVetor()
        {
            palavras = new String[10];
            dicas = new String[10];

            palavras[0] = "monkey d luffy";
            dicas[0] = "Usuário da fruta de borracha";
            palavras[1] = "chopper";
            dicas[1] = "Médico dos Mugiwaras";
            palavras[2] = "going merry";
            dicas[2] = "Primeiro navio dos Mugiwaras";
            palavras[3] = "cp9";
            dicas[3] = "Organização secreta do Governo Mundial";
            palavras[4] = "enel";
            dicas[4] = "deus do trovão";
            palavras[5] = "roronoa zoro";
            dicas[5] = "Caçador de Piratas";
            palavras[6] = "usopp";
            dicas[6] = "Atirador dos mugiwaras";
            palavras[7] = "gomu gomu no pistol";
            dicas[7] = "Ataque principal do Luffy";
            palavras[8] = "buggy";
            dicas[8] = "Palhaço";
            palavras[9] = "nico robin";
            dicas[9] = "Arqueóloga dos Mugiwaras";

        }

        private void IniciaJogo()
        {
            //escolher a palavra
            Random r = new Random();
            pospalavra = r.Next(0, 10);
            palavra = palavras[pospalavra];
            //inserir o texto em tela
            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }
            textoPalavraSecreta.Text = tela;
            textoDicas.Text = dicas[pospalavra];
            //total de tentativas
            tentativas = 5;
            textoTotalTentativas.Text = tentativas.ToString();
            tentativasRestantes.Text = tentativas.ToString();
            letrasDigitadas.Text = "";
        }

        private void BotaoStart_Click(object sender, EventArgs e)
        {
            painelGameOver.Visible = false;
            painelJogo.Visible = true;
            botaoStart.Visible = false;

            this.IniciaJogo();
        }

        private void PainelJogo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BotaoOK_Click(object sender, EventArgs e)
        {
            Boolean encontrou = false;
            Char letra = 'a';
            int pLetra = 0;
            letrasDigitadas.Text = letrasDigitadas.Text + letrasDigitadas.Text;
            try
            {
                letra = Convert.ToChar(textoLetra.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Digite uma letra!");
                return;
            }
            //entrada de dados OK!
            String txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    pLetra = i;
                    //atualizar o texto na tela
                    txt = txt + textoLetra.Text;
                }
                else
                {
                    txt = txt + tela[i];
                }
            }
            tela = txt;
            textoPalavraSecreta.Text = tela;
            textoLetra.Clear();

            if (encontrou == false)
            {
                tentativas--;
            }
            tentativasRestantes.Text = tentativas.ToString();

            if (textoPalavraSecreta.Text.IndexOf('#') == -1)
            {
                //caso não tenha ganhado o jogo
                painelJogo.Visible = false;
                painelGameOver.Visible = true;
                botaoStart.Visible = true;
            }
            if (tentativas <= 0)
            {
                painelJogo.Visible = false;
                painelGameOver.Visible = true;
                botaoStart.Visible = true;
            }

        }

        private void TextoLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
