using System;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                12         
             */

            int x = 60;
            int y = 24;

            Console.WriteLine(CalcularMDC(x, y));

            Console.ReadKey();
        }

        private static int CalcularMDC(int x, int y)
        {
            //algoritmo de Euclides (http://pt.wikipedia.org/wiki/Algoritmo_Euclidiano)
            return y == 0 ? x : CalcularMDC(y, x % y);
        }
    }
}
