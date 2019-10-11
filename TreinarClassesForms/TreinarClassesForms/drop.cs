using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinarClassesForms
{
    class drop
    {
        string _nome;
        int _valor;

        public string Nome { get => _nome; set => _nome = value; }
        public int Valor { get => _valor; set => _valor = value; }

        public drop(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
