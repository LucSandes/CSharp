using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaLoginAlunos : Form
    {
        public telaLoginAlunos()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)//Botao Voltar
        {
            this.Close();
        }

        private void TelaLoginAlunos_Load(object sender, EventArgs e)
        {

        }

        private void botaoLoginAluno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (textoRa.Text == "123" && textoSenhaAluno.Text == "123")
            {
                Aluno.telaMenuAluno telaMenuAluno = new Aluno.telaMenuAluno();
                telaMenuAluno.ShowDialog();
                Visible = true;
            }
            else if (textoRa.Text == "" && textoSenhaAluno.Text == "")
            {
                MessageBox.Show("Digite um RA e senha!");
            }
            else
            {
                MessageBox.Show("Aluno não existe");
            }
        }

        private void TextoSenhaAluno_TextChanged(object sender, EventArgs e)
        {
            textoSenhaAluno.PasswordChar = '*';
        }
    }
}
