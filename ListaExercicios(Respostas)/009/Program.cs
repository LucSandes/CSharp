using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                120         
             */

            int x = 60;
            int y = 24;

            Console.WriteLine(x * y / CalcularMDC(x, y));

            Console.ReadKey();
        }

        private static int CalcularMDC(int x, int y)
        {
            return y == 0 ? x : CalcularMDC(y, x % y);
        }
    }
}
