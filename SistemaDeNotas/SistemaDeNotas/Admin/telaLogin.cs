﻿using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {

            if (textoUsuario.Text == "admin" && textoSenha.Text == "123")
            {
                telaMenuAdm telaMenu = new telaMenuAdm();
                telaMenu.ShowDialog();
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

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextoSenha_TextChanged(object sender, EventArgs e)
        {
            textoSenha.PasswordChar = '*';
        }

        private void TextoUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}