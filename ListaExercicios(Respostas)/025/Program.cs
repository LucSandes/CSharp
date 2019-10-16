using System;

namespace _025
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite a temperatura em Faranheit: 32
                0
             
                -------------------------------------------
             
                Digite a temperatura em Faranheit: 212
                100
             */

            Console.Write("Digite a temperatura em Faranheit: ");
            var temp = Int32.Parse(Console.ReadLine());

            Console.WriteLine((temp - 32) / 1.8);

            Console.ReadKey();
        }
    }
}
