using System;
using System.Collections.Generic;
using System.Linq;

namespace ForeachStatement
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int id;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            //Livro l1 = new Livro();
            Livro l1;
            l1.id = 1;
            l1.titulo = "Dom Casmurro";
            l1.autor = "Machado de Assis";
            l1.anoPublicacao = 1234;

            Livro l2;
            l2.id = 2;
            l2.titulo = "Jorge Amado";
            l2.autor = "Gabriela";
            l2.anoPublicacao = 5678;

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Codigo do Livro : " + item.id.ToString());
                Console.WriteLine("Nome do Livro : " + item.titulo.ToString());
                Console.WriteLine("Autor do Livro : " + item.autor.ToString());
                Console.WriteLine("Ano de publicação do Livro : " + item.anoPublicacao.ToString());
                Console.WriteLine("_______________________________________________________");
            }

            //for (int i = 0; i < livros.Count; i++)
            //{
            //    Livro l = livros.ElementAt(i);
            //    l.autor;
            //}

            Console.ReadKey();
        }
    }
}
