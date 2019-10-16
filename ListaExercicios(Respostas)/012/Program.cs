using System;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                28 -> é um número perfeito
            
                ------------------------------

                26 -> não é um número perfeito
             */

            var x = 28;

            var soma = 0;

            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0) soma += i;
            }

            Console.WriteLine("{0} -> {1}é um número perfeito", x, soma==x?"":"não ");

            Console.ReadKey();
        }
    }
}
