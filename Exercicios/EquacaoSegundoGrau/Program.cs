using System;

namespace EquacaoSegundoGrau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receba três valores double que são os valores de a, b e c numa " +
                "equação de segundo grau (ax²+bx+c=0) e imprima na tela");
            Console.WriteLine("1 - Não é equação do segundo grau (a = 0)");
            Console.WriteLine("2 - Não possui raízes em R (delta<0)");
            Console.WriteLine("3 - Possui uma raíz e é _____ (calcular) ");
            Console.WriteLine("4 - Possui duas raízes e são _____ e _____ (calcular)");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            double a, b, c, x;
            double r1, r2, delta;

            Console.WriteLine("Solução para a equação > ax²+bx+c=0");
            //Console.Write("Digite o valor de 'x' da questão: ");
            //x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de 'a' da questão: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de 'b' da questão: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de 'c' da questão: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - (4 * a * c);

            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (a == 0)
                Console.WriteLine("O 'a' é igual a zero, portanto não é uma equação de segundo grau!");
            else if (delta < 0)
                Console.WriteLine("Não possui raizes, porque o delta < 0");
            else if (delta == 0)
                Console.WriteLine("Raiz: " + r1);
            else if (delta > 0)
            {
                Console.WriteLine("Raiz 1: " + r1);
                Console.WriteLine("Raiz 2: " + r2);
            }

            Console.ReadKey();
        }
    }
}
