using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAlunos : Form
    {
        public telaAlunos()
        {
            InitializeComponent();
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoExcluirAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoPesquisarAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoAlterarAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoLimparAluno_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                //if (c.GetType().ToString() == "System.Windows.Form.Textbox")
                //{
                //    c.Text = "";
                //}
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;
                textBox9.Text = string.Empty;
                textBox10.Text = string.Empty;
                textBox11.Text = string.Empty;
                textBox12.Text = string.Empty;
            }
        }

        private void TextoTelaAlunos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
