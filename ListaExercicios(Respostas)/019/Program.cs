using System;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    100 -> 3,13159290355855
                   1000 -> 3,14059265383979
                  10000 -> 3,14149265359003
                 100000 -> 3,14158265358972
                1000000 -> 3,14159165358977
             */

            for (int i = 100; i <= 1000000; i *= 10)
            {
                ImprimirPi(i);
            }

            Console.ReadKey();
        }

        private static void ImprimirPi(int x)
        {
            double pi = 0;

            for (int i = 1; i <= x * 2; i += 4)
            {
                pi += 1.0 / i;
                pi -= 1.0 / (i + 2);
            }

            pi *= 4;

            Console.WriteLine("{0,7} -> {1}", x, pi);
        }
    }
}
