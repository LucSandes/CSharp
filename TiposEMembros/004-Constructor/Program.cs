using System;

namespace _004_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();

            pessoa.Codigo = 1;
            pessoa.Nome = "Luccas";

            Console.WriteLine(pessoa); //pessoa.ToString()

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        /*ordem dentro da classe:
         * Fields(campos)
         * Properties(propriedades)
         * Constructor(construtor)
         * Methods(métodos)
         * Methods(Override)(métodos de sobreposição)
        */
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public String CorDoSangue { get; private set; }

        //ctor(code snippet)
        public Pessoa()
        {
            CorDoSangue = "Vermelho";
        }

        //override -> indica sobreposição de um membro da classe base
        public override string ToString()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }

    }
}