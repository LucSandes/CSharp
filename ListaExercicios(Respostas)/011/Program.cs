using System;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                77 -> não é primo
             
                --------------------------             
                          
                73 -> é primo
             */

            int x = 77;

            bool primo = true;

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            Console.WriteLine("{0} -> {1}é primo", x, primo ? "": "não ");

            Console.ReadKey();
        }
    }
}
