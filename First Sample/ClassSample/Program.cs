using System;

namespace ClassSample
{
    class Program
    {
        //ponto de entrada de uma classe
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();
            Aluno a3 = new Aluno("Alberto", 25);

            a1.Nome = "Luccas";
            a1.Idade = 23;

            a2.Nome = "Amanda";
            a2.Idade = 25;

            Console.WriteLine(a1.Nome);
            Console.WriteLine(a3.Nome);
            Console.WriteLine(a1.GetIdadeTwice());


            Console.ReadKey(); 
            a1.Limpar();
            
        }
    }
}
