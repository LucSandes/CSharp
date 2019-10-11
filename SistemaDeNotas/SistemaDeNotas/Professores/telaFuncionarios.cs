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
    public partial class telaFuncionarios : Form
    {
        public telaFuncionarios()
        {
            InitializeComponent();
        }
        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }


        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TelaFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
