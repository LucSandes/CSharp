using System;

namespace _016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número menor que 13: 10
                3628800
             */

            Console.Write("Digite um número menor que 13: ");

            int x = Int32.Parse(Console.ReadLine());

            if (x >= 13) return;

            Console.WriteLine(CalcularFatorial(x));

            Console.ReadKey();
        }

        private static int CalcularFatorial(int x)
        {
            return x == 0 ? 1 : x * CalcularFatorial(x - 1);
        }
    }
}
