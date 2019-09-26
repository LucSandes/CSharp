using System;

namespace Divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado um número qualquer, ache todos os seus divisores");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int n, r;

            Console.Write("Digite o número: ");
            n = Convert.ToInt32(Console.ReadLine());

            r = n;

            while (r != 0)
            {
                if (n % r == 0)
                {
                    Console.WriteLine(r);
                }
                r = r - 1;
            }

            Console.ReadKey();
        }
    }
}
