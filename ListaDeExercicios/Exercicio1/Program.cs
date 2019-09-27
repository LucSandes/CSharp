using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(". Faça um algoritmo que leia a idade de uma pessoa expressa em anos, " +
                "meses e dias e mostre - a expressa em dias.Leve em consideração o ano com 365 dias e o " +
                "mês com 30.(Ex: 3 anos, 2 meses e 15 dias = 1170 dias.)");

            int d, m, a, idade;
            int diasD, diasM, diasA, diasTotal;

            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite seu dia de nascimento: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite mês de nascimento: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            a = Convert.ToInt32(Console.ReadLine());

            diasD = d;

            diasM = 


            diasTotal = diasD + diasM + diasA;

            Console.WriteLine("De acordo com a sua idade(" + idade + ") a quantidade de dias vividos são de " + diasTotal);

            Console.ReadKey();
        }
    }
}
