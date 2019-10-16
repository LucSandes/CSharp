using System;
using System.Windows.Forms;

namespace SistemaDeNotas
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void BotaoAlunos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLoginAlunos telaLoginAlunos = new telaLoginAlunos();
            telaLoginAlunos.ShowDialog();
            this.Visible = true;
        }

        private void BotaoProfessores_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLoginProfessoresDirecao telaLoginProfessoresDirecao = new telaLoginProfessoresDirecao();
            telaLoginProfessoresDirecao.ShowDialog();
            this.Visible = true;
        }

        private void BotaoFuncionarios_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLoginFuncionarios telaLoginFuncionarios = new telaLoginFuncionarios();
            telaLoginFuncionarios.ShowDialog();
            this.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLogin telaLogin = new telaLogin();
            telaLogin.ShowDialog();
            this.Visible = true;
        }
    }
}
