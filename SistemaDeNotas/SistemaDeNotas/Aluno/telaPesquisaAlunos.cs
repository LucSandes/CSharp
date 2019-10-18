using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaPesquisaAlunos : Form
    {
        List<Aluno.Aluno> listaAlunos = new List<Aluno.Aluno>();

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;//limparTextBoxes(this.Controls);
                }
            }
        }

        public telaPesquisaAlunos()
        {
            InitializeComponent();
            Aluno.Aluno a1 = new Aluno.Aluno();
            Aluno.Aluno a2 = new Aluno.Aluno();
            Aluno.Aluno a3 = new Aluno.Aluno();
            Aluno.Aluno a4 = new Aluno.Aluno();
            Aluno.Aluno a5 = new Aluno.Aluno();
        }

        public string Propriedade { get; set; }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaPesquisaAlunos_Load(object sender, EventArgs e)
        {
            if (!this.Propriedade.Equals(""))
            {
                textoNomeAluno.Text = this.Propriedade;
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextoNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoAlterarAluno_Click(object sender, EventArgs e)
        {
            //textoNomeAluno.Enabled = false;
            textoNomeAluno.Enabled = true;
            textoDataAluno.Enabled = true;
            textoEnderecoAluno.Enabled = true;
            textoTelefoneAluno.Enabled = true;
            textoEmailAluno.Enabled = true;
            textoCursoAluno.Enabled = true;
            textoCpfAluno.Enabled = true;
            textoCidadeAluno.Enabled = true;
            textoEstadoAluno.Enabled = true;
            textoDataMatriculaAluno.Enabled = true;
            textoRaAluno.Enabled = true;

        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void textoCpfAluno_Enter(object sender, EventArgs e)
        {
            if (textoCpfAluno.Text == "Apenas números!!")
            {
                textoCpfAluno.Text = "";
                textoCpfAluno.ForeColor = Color.Black;
            }
        }

        private void TextoCpfAluno_Leave(object sender, EventArgs e)
        {
            if (textoCpfAluno.Text == "")
            {
                textoCpfAluno.Text = "Apenas números!!";
                textoCpfAluno.ForeColor = Color.Silver;
            }
        }
    }
}
