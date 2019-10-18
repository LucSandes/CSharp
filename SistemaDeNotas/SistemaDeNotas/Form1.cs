using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void BotaoAlunos_Click(object sender, EventArgs e)
        {
            telaLoginAlunos telaLoginAlunos = new telaLoginAlunos();
            telaLoginAlunos.TopLevel = false;
            telaLoginAlunos.Visible = true;
            panel1.Controls.Add(telaLoginAlunos);
            telaLoginAlunos.BringToFront();
        }

        private void BotaoProfessores_Click(object sender, EventArgs e)
        {

            telaLoginProfessoresDirecao telaLoginProfessoresDirecao = new telaLoginProfessoresDirecao();
            telaLoginProfessoresDirecao.TopLevel = false;
            telaLoginProfessoresDirecao.Visible = true;
            panel1.Controls.Add(telaLoginProfessoresDirecao);
            telaLoginProfessoresDirecao.BringToFront();

        }

        private void BotaoFuncionarios_Click(object sender, EventArgs e)
        {
            telaLoginFuncionarios telaLoginFuncionarios = new telaLoginFuncionarios();
            telaLoginFuncionarios.TopLevel = false;
            telaLoginFuncionarios.Visible = true;
            panel1.Controls.Add(telaLoginFuncionarios);
            telaLoginFuncionarios.BringToFront();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            telaLogin telaLogin = new telaLogin();
            telaLogin.TopLevel = false;
            telaLogin.Visible = true;
            panel1.Controls.Add(telaLogin);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("www.fatecsp.br");
            Process.Start(sInfo);
        }
    }
}
