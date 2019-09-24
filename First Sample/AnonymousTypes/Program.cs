using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            //para colocar valores nullable
            int? i = null;
            string s = null;
            double? d = null;

            var valores = new []{ new { idade = 18, nome = "Luccas" }, new { idade = 20, nome = "Amanda"}};

            foreach (var item in valores)
            {
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("Nome: " + item.nome.ToString());
                Console.WriteLine("-----------------------------");
            }
            Console.ReadKey();
        }   
    }
}
