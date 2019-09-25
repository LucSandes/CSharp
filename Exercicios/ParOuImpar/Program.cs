using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resto;
            Console.WriteLine("Verificar se o número é par ou ímpar!");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite o primeiro número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resto = numero % 2;

            if (resto == 1)
            {
                Console.WriteLine("O número é ímpar!");
            }
            else
            {
                Console.WriteLine("O número é par!");
            }

            Console.ReadKey();
        }
    }
}
