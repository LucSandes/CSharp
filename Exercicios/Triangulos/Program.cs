using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receba três valores double que são as medidas " +
                "dos lados de um triângulo. Apresente na tela mensagens:");
            Console.WriteLine("1 - Não é um triângulo (a soma de dois lados é" +
                " menor que o outro ou se algum lado é menor ou igual a zero);");
            Console.WriteLine("2 - É um triângulo equilátero (três lados iguais)");
            Console.WriteLine("3 - É um triângulo escaleno (três lados diferentes)");
            Console.WriteLine("4 - É um triângulo isósceles(dois lados iguais e um diferente)");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            double l1, l2, l3;

            Console.Write("Digite o lado 1: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o lado 2: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o lado 3: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            if (l1 <= 0 || l2 <= 0 || l3 <= 0)
            {
                if (l1 + l2 > l3 || l2 + l3 > l1)
                    Console.WriteLine("Não é um triângulo");
            }
            else if (l1 == l2 && l1 == l3)
                Console.WriteLine("É um triângulo equilátero (três lados iguais)");
            else if (l1 != l2 && l1 != l3)
                Console.WriteLine("É um triângulo escaleno (três lados diferentes)");
            else if (l1 == l2 || l1 == l3)
            {
                if(l1 != l2 || l1 != l3)
                    Console.WriteLine("É um triângulo isósceles(dois lados iguais e um diferente)");
            }
            
            Console.ReadKey();
        }
    }
}
