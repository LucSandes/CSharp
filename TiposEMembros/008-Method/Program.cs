using System;

namespace _008_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirQualquerCoisa();
            ImprimirQualquerCoisa();
            ImprimirQualquerCoisa();

            //Encapsulamento -> permite o uso de recurso sem que o programador conheça a implementação

            Console.WriteLine(Math.Sqrt(81));

            ImprimirMensagem("Opa!");
            ImprimirMensagem("Blz?");

            Console.WriteLine(Somar(10, 40));

            var x = Somar(25, 15);
            Console.WriteLine(x);


            Console.ReadKey();
        }

        //methods
        private static void ImprimirQualquerCoisa()
        {
            Console.WriteLine("Qualquer coisa");
        }

        private static void ImprimirMensagem(String msg)
        {
            Console.WriteLine(msg);
        }

        private static int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
