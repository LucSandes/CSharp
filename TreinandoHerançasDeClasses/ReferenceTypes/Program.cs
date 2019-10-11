using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            //Tipo nome;

            //inicializar
            //nome = new Tipo();

            //declarar e inicilizar na mesma linha

            Pessoa p = new Pessoa();

            p.codigo = 1;
            p.nome = "adão";
            Console.WriteLine("{0} -> {1}", p.codigo, p.nome);
        }
    }

    //value type => struct, enum
    //reference type => class, delegate

    class Pessoa
    {
        public int codigo; //campo
        public string nome;
    }
}
