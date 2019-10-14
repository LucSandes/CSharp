using System;

namespace IfTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o primeiro lado: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro lado: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro lado: ");
            c = Convert.ToInt32(Console.ReadLine());

            //1,1,1 - equilatero
            //2,2,1 - isósceles
            //3,4,5 - escaleno
            //1,1,2 - não é triangulo
            //-1,23,3 - não é triangulo

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
            {
                Console.WriteLine("NÃO É UM TRIÂNGULO!");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("TRIÂNGULO EQUILÁTERO!");
            }
            else if (a != b && a != c && b != c)
            {
                Console.WriteLine("TRINÂNGULO ESCALENO!");
            }
            else
                Console.WriteLine("TRIÂNGULO ISÓSCELES");

            Console.ReadKey();
        }
    }
}
