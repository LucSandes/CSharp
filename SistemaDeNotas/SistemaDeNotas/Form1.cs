using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile("https://media.giphy.com/media/lqXqK9FeV586MIuBby/source.mp4");
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            telaLogin telaLogin = new telaLogin();
            telaLogin.ShowDialog();
        }

        private void BotaoAlunos_Click(object sender, EventArgs e)
        {
            telaLoginAlunos telaLoginAlunos = new telaLoginAlunos();
            telaLoginAlunos.ShowDialog();
        }

        private void BotaoProfessores_Click(object sender, EventArgs e)
        {
            telaLoginProfessoresDirecao telaLoginProfessoresDirecao = new telaLoginProfessoresDirecao();
            telaLoginProfessoresDirecao.ShowDialog();
        }

        private void BotaoFuncionarios_Click(object sender, EventArgs e)
        {
           telaLoginFuncionarios telaLoginFuncionarios = new telaLoginFuncionarios();
           telaLoginFuncionarios.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
