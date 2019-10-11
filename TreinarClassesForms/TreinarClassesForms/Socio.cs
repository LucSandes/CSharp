using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreinarClassesForms
{
    public class Socio
    {
        public Socio()
        {
            MessageBox.Show("Objeto criado com sucesso!");
        }

        private string nome;
        private string cpf;
        private string rg;
        private DateTime nascimento;
        private string telefone;
        private string endereco;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public void Cadastrar()
        {
            MessageBox.Show(string.Format("Cadastrando sócio...\r\nNome: {0},  Rg: {1}, Cpf: {2}", nome,rg,cpf));
        }

        public bool ConfirmarCadastro(int tipo)
        {
            if (tipo == 1)
            {
                return true;
            }
            else
                return true;
        }

        public bool ValidarCadastro(int tipo)
        {
            if (tipo == 1)
                return true;
            else
                return true;
        }

        public void Alterar()
        {
            MessageBox.Show("Alterando socio...");
        }
    }
}
