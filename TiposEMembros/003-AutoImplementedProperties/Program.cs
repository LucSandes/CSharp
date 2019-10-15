using System;

namespace _003_AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();

            pessoa.Codigo = 1;
            pessoa.Nome = "Luccas";
            //pessoa.CorDoSangue = "VERMELHO";

            Console.WriteLine("Id: {0}", pessoa.Codigo);
            Console.WriteLine("Nome: {0}", pessoa.Nome);
            Console.WriteLine("Cor do Sangue: {0}", pessoa.CorDoSangue);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public String CorDoSangue { get; private set; }

    }
}
