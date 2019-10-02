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
        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            telaLogin telaLogin = new telaLogin();
            telaLogin.ShowDialog();
        }
    }
}
