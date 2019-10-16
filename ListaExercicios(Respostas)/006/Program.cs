using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1 -> 1

                -----------------------------
             
                5 -> 15

                -----------------------------
             
                10 -> 55
             */

            int n = 1;

            Console.WriteLine("{0} -> {1}", n, (n * (n + 1)) / 2);

            Console.ReadKey();
        }
    }
}
