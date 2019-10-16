using System;

namespace _024
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite a temperatura em Celsius: 0
                32
             
                -------------------------------------------
             
                Digite a temperatura em Celsius: 100
                212
             */

            Console.Write("Digite a temperatura em Celsius: ");
            var temp = Int32.Parse(Console.ReadLine());

            Console.WriteLine(temp * 1.8 + 32);

            Console.ReadKey();
        }
    }
}
