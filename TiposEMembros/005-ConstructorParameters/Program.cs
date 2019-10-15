using System;

namespace _005_ConstructorParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine(p1);

            p1.Codigo = 1;
            p1.Nome = "Amanda";

            Console.WriteLine(p1);

            Console.WriteLine(new Pessoa(2, "Ana"));

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

        //sobrecarga de construtores ou overload
        /*assinatura: Nome(tipos)
         * Pessoa()
         * Pessoa(int, String)
        */
        public Pessoa() : this(0, null)
        {
        }

        public Pessoa(int codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
            CorDoSangue = "Vermelho";
        }

        //override -> indica sobreposição de um membro da classe base
        public override string ToString()
        {
            return String.Format("{0} -> '{1}' com cor do sangue {2}", Codigo, Nome, CorDoSangue);
        }

    }
}
