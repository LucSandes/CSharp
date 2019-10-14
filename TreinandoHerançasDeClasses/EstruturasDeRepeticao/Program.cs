using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nome = conteúdo;
            // var x; <- errado

            var s = "ordem e progresso"; //variável tipada implicitamente
            // String s = "ordem e progresso"

            foreach (var item in s) //Read-Only
            {
                //item = 'x'; -> item é cópia de cada char da string 
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
