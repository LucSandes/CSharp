using System;
using System.Windows.Forms;

namespace SistemaControleFinanceiro
{
    public partial class ContaCliente : Form
    {
        public ContaCliente()
        {
            InitializeComponent();
        }

        private void NotaALuno_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Luccas";
            cliente.Ra = "81723375";
            cliente.Notas = 10;
            cliente.BoolAprovado = "Sim";

            textoNomeCC.Text = Convert.ToString(cliente.Nome);
            textoCPF.Text = Convert.ToString(cliente.Ra);
            textoSaldoCC.Text = Convert.ToString(cliente.Notas);
            boolEmprestimo.Text = Convert.ToString(cliente.BoolAprovado);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
