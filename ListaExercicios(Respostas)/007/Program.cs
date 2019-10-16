using System;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1 2 3 4 5 6 10 12 15 20 30 60
             */

            int x = 60;

            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0) Console.Write("{0} ", i);
            }

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
