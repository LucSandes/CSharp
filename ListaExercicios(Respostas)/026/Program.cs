using System;

namespace _026
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número inteiro: 1
                raíz quadrada de 1: 1
                raíz cúbica de 1..: 1
                quadrado de 1.....: 1
                cubo de 1.........: 1
             
                -------------------------------------------
             
                Digite um número inteiro: 10
                raíz quadrada de 10: 3,16227766016838
                raíz cúbica de 10..: 2,15443469003188
                quadrado de 10.....: 100
                cubo de 10.........: 1000
             */

            Console.Write("Digite um número inteiro: ");
            var x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("raíz quadrada de {0}: {1}", x, Math.Sqrt(x));
            Console.WriteLine("raíz cúbica de {0}..: {1}", x, Math.Pow(x, (1.0 / 3)));
            Console.WriteLine("quadrado de {0}.....: {1}", x, Math.Pow(x, 2));
            Console.WriteLine("cubo de {0}.........: {1}", x, Math.Pow(x, 3));

            Console.ReadKey();
        }
    }
}
