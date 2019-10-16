using System;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                10 -> par  
                
                ----------------------

                11 -> impar  
             */

            int x = 10;

            Console.WriteLine("{0} -> {1}", x, x % 2 == 0 ? "par" : "ímpar");

            Console.ReadKey();
        }
    }
}
