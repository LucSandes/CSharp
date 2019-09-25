using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3, a4, a5, media, soma;

            Console.WriteLine("Calculo da média de Idade dos alunos!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Idade do aluno 1: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Idade do aluno 2: ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Idade do aluno 3: ");
            a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Idade do aluno 4: ");
            a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Idade do aluno 5: ");
            a5 = Convert.ToDouble(Console.ReadLine());


            soma = a1 + a2 + a3 + a4 + a5;
            media = soma / 5;

            Console.WriteLine("A soma total das idades: " + soma);
            Console.WriteLine("A média de idade é: " + media);
            Console.ReadKey();
        }
    }
}
