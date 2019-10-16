using System;

namespace _018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    100 -> 3,12607890021541
                   1000 -> 3,14002381860059
                  10000 -> 3,14143559358986
                 100000 -> 3,14157694582264
                1000000 -> 3,14159108279491
             */

            for (int i = 100; i <= 1000000; i *= 10)
            {
                ImprimirPi(i);
            }

            Console.ReadKey();
        }

        private static void ImprimirPi(int x)
        {
            double pi = 2;

            for (int i = 2; i <= x+1; i += 2)
            {
                pi *= (double)i / (i - 1);
                pi *= (double)i / (i + 1);
            }

            Console.WriteLine("{0,7} -> {1}", x, pi);
        }
    }
}
