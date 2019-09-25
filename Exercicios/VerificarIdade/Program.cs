using System;

namespace VerificarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, pessoas = 0, i = 0;
            Console.WriteLine("Verificar se é maior de 18 anos!");

            while (i < 10)
            {
                i++;
                Console.Write("Qual a  idade da pessoa? ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 18)
                {
                    pessoas++;
                }
            }
            Console.WriteLine("A quantidade de pessoas com maior de 18 anos nessa lista é " + "'" + pessoas + "'");
            Console.ReadKey();
        }
    }
}
