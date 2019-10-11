using System;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type não aceita conteúdo null
            //reference type aceita conteúdo null

            int x = 10;
            //x = null; //não aceita

            Object o = new Object();

            o = null;

            Console.WriteLine(x);
            Console.WriteLine(o);
            Console.ReadKey();

            //Garbage Collector -> limpa o heap, eliminando os objetos que não tem referência(unreacheable state)
        }
    }
}
