using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Lado a: 0
                Lado b: 1
                Lado c: 2
                não é um triângulo

                ------------------------------

                Lado a: 1
                Lado b: 1
                Lado c: 1
                é um triângulo equilátero

                ------------------------------

                Lado a: 3
                Lado b: 4
                Lado c: 5
                é um triângulo escaleno

                ------------------------------

                Lado a: 2
                Lado b: 2
                Lado c: 1
                é um triângulo isósceles
            */

            Console.Write("Lado a: ");
            var a = Double.Parse(Console.ReadLine());

            Console.Write("Lado b: ");
            var b = Double.Parse(Console.ReadLine());

            Console.Write("Lado c: ");
            var c = Double.Parse(Console.ReadLine());

            var msg = "é um triângulo isósceles";

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || c + b <= a)
            {
                msg = "não é um triângulo";
            }
            else if (a == b && b == c)
            {
                msg = "é um triângulo equilátero";
            }
            else if (a != b && b != c && a != c)
            {
                msg = "é um triângulo escaleno";
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
