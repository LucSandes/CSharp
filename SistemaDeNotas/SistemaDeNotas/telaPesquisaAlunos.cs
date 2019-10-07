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
    public partial class telaPesquisaAlunos : Form
    {
        List<Alunos> listaAlunos = new List<Alunos>();
        public telaPesquisaAlunos()
        {
            InitializeComponent();
            Alunos a1 = new Alunos();
            Alunos a2 = new Alunos();
            Alunos a3 = new Alunos();
            Alunos a4 = new Alunos();
            Alunos a5 = new Alunos();
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
    }
}
