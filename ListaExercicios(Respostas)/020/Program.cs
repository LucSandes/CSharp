using System;

namespace _020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número inteiro: 1
                perímetro da circunferência: 6,28318530717959
                área do círculo............: 3,14159265358979
                volume da esfera...........: 4,18879020478639

                bônus: área da da esfera...: 12,5663706143592
             */

            Console.Write("Digite um número inteiro: ");

            var x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("perímetro da circunferência: {0}", 2 * Math.PI * x);
            Console.WriteLine("área do círculo............: {0}", Math.PI * Math.Pow(x, 2));
            Console.WriteLine("volume da esfera...........: {0}", 4 * Math.PI * Math.Pow(x, 3) / 3);

            Console.WriteLine();
            
            Console.WriteLine("bônus: área da da esfera...: {0}", 4 * Math.PI * Math.Pow(x, 2));

            Console.ReadKey();
        }
    }
}
