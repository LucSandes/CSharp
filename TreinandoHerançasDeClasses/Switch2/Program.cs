using System;

namespace Switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Digite o dia da semana de 1 a 7: ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Dia Útil!");
                    break;
                case 1:
                case 7:
                    Console.WriteLine("Final de Semana!");
                    break;
                default:
                    Console.WriteLine("Erro!");
                    break;
            }

            if (dia >= 2 && dia <= 6)
            {
                Console.WriteLine("Dia Útil!");
            }
            else if (dia == 1 || dia == 7)
            {
                Console.WriteLine("Final de Semana!");
            }
            else
                Console.WriteLine("Erro!");

            Console.ReadKey();
        }
    }
}
