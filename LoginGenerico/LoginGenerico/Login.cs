using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginGenerico
{
    public partial class Login : Form
    {
        //Os valores da propriedade serão passados para o Program.cs
        public bool Logado { get; set; }
        public string Usuario { get; set; }

        public Login()
        {
            InitializeComponent();
            //Pegar o valor da variável nas configurações do aplicativo
            tbUsuario.Text = Properties.Settings.Default.Usuario;
            
            //Forçar o PictureBox como pai dos controles para a transparência funcionar
            lblUsuario.Parent = pbBackground;
            tbUsuario.Parent = pbBackground;
            lblSenha.Parent = pbBackground;
            tbSenha.Parent = pbBackground;
            lblDadosInvalidos.Parent = pbBackground;
            btnSair.Parent = pbBackground;
            btnLogin.Parent = pbBackground;
            pbCadeado.Parent = pbBackground;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Vincular Enter ao btnLogin
            this.AcceptButton = btnLogin;
            //Vincular ESC ao btnSair
            this.CancelButton = btnSair;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //Nesta parte recupere os valores do seu banco de dados
            string usuarioBanco = "admin";
            string senhaBanco = "123";
            string usuarioDigitado = tbUsuario.Text;
            string senhaDigitada = tbSenha.Text;

            if ((usuarioDigitado == usuarioBanco) && (senhaDigitada == senhaBanco))
            {
                Logado = true;
                Usuario = tbUsuario.Text;

                //Salvar o nome de usuário nas configurações do aplicativo
                Properties.Settings.Default.Usuario = tbUsuario.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                Logado = false; ;
                lblDadosInvalidos.Visible = true;
            }
            this.Cursor = Cursors.Default;
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            lblDadosInvalidos.Visible = false;
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            lblDadosInvalidos.Visible = false;
        }

        private void LblDadosInvalidos_Click(object sender, EventArgs e)
        {

        }
    }
}