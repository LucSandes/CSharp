using System;
using System.Linq;
using System.Text;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite uma frase: A grama é amarga!
                AGRAMAÉAMARGA
                AGRAMAÉAMARGA
                True
             */

            Console.Write("Digite uma frase: ");

            var frase = Console.ReadLine().ToUpper();

            var sb = new StringBuilder();

            for (int i = 0; i < frase.Length; i++)
            {
                if (Char.IsLetterOrDigit(frase[i]))
                    sb.Append(frase[i]);
            }

            var x = sb.ToString();
            var y = new String(x.Reverse().ToArray<char>());

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(x.Equals(y));

            Console.ReadKey();
        }
    }
}
