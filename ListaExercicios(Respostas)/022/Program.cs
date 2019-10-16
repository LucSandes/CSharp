using System;
using System.Numerics;

namespace _022
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                  5 -> 2,70833333333333
                 20 -> 2,71828182845905
                 50 -> 2,71828182845905
                100 -> 2,71828182845905
                150 -> 2,71828182845905
            */

            ImprimirE(5);
            ImprimirE(20);
            ImprimirE(50);
            ImprimirE(100);
            ImprimirE(150);

            Console.ReadKey();
        }

        private static void ImprimirE(int x)
        {
            var e = 0.0;

            for (int i = 0; i < x; i++)
            {
                e += Math.Exp(BigInteger.Log(BigInteger.One) - BigInteger.Log(CalcularFatorial(i)));
            }

            Console.WriteLine("{0,3} -> {1}", x, e);
        }

        private static BigInteger CalcularFatorial(BigInteger x)
        {
            return x == 0 ? 1 : x * CalcularFatorial(x - 1);
        }
    }
}
