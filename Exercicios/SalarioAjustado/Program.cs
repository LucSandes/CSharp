using System;

namespace SalarioAjustado
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual = 0;
            double salarioNovo = 0;

            Console.WriteLine("Ajuste de salário");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o salario: ");
                salarioAtual = Convert.ToDouble(Console.ReadLine());

                if (salarioAtual <= 300)
                {
                    salarioNovo = salarioAtual * 1.5;
                }
                else
                {
                    salarioNovo = salarioAtual + ((salarioAtual * 30) / 100);
                }

                Console.WriteLine("O salário ajustado é: " + salarioNovo);
                Console.ReadKey();
            }
        }
    }
}
