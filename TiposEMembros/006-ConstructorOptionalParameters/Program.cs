using System;

namespace _006_ConstructorOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pessoa();
            var p2 = new Pessoa(nome: "Tio Chico");
            var p3 = new Pessoa(10, "Tia Clotilde");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

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
        public Pessoa(int codigo = 0, String nome = null)
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
