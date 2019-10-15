using System;

namespace _007_ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa()
            {
                Codigo = 2,
                Nome = "Eva"
            };

            Console.WriteLine(p);

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
        public Pessoa()
        {
            Console.WriteLine("Passei Aqui!");

            CorDoSangue = "Vermelho";
        }

        //override -> indica sobreposição de um membro da classe base
        public override string ToString()
        {
            return String.Format("{0} -> '{1}' com cor do sangue {2}", Codigo, Nome, CorDoSangue);
        }

    }
}
