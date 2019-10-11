using System;

namespace IfTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            //1,1,1 - equilatero
            //2,2,1 - isósceles
            //3,4,5 - escaleno
            //1,1,2 - não é triangulo
            //-1,23,3 - não é triangulo

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
            {

            }
            Console.WriteLine("Não é um triangulo!");

            Console.WriteLine("Hello World!");
        }
    }
}
