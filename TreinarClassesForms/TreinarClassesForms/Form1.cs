using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinarClassesForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoInstanciarObjeto_Click(object sender, EventArgs e)
        {
            Socio soc = new Socio();

            soc.Nome = "Luccas Sandes";
            soc.Rg = "38.292.660-2";
            soc.Cpf = "370.338.028-46";
            soc.Nascimento = DateTime.Parse("22/01/1996");
            soc.Telefone = "(11)2231-0176";
            soc.Endereco = "Avenida do Guacá, 26";

            soc.Cadastrar();
            if (soc.ConfirmarCadastro(1))
                MessageBox.Show("Cadastro Confirmado!");
            if(soc.ValidarCadastro(1))
                MessageBox.Show("Sócio Validado!");

            soc.Alterar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList teste = new ArrayList();

            teste.Add(new drop("Luccas", 1));
            teste.Add(new drop("Amanda", 2));

            comboBox1.DataSource = teste;

            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "valor";
        }
    }
}
