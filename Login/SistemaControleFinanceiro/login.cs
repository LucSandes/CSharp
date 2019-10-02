using System;
using System.Windows.Forms;

namespace SistemaControleFinanceiro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {

            if (textoUsuario.Text == "admin" && textoSenha.Text == "123")
            {

                telaPrincipal Principal = new telaPrincipal();
                Principal.ShowDialog();

            }
            else if (textoUsuario.Text == "" && textoSenha.Text == "")
            {
                MessageBox.Show("Digite um usuário e senha!");
            }
            else
            {
                MessageBox.Show("Usuario nao existe");
            }
        }

        private void TextoUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextoSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
