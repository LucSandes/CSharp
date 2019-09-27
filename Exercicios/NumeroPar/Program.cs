using System;

namespace NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado um número qualquer, verifique se ele é par");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int n;

            Console.Write("Digite o número: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("O número digitado é zero!");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
                Console.WriteLine("O número é ímpar!");

            Console.ReadKey();
        }
    }
}
