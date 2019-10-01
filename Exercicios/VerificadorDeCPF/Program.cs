using System;

namespace VerificadorDeCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de CPF");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int contador = 0;
            int soma = 0;

            while (contador < 5)
            {

                Console.WriteLine(contador);

                contador++;
                soma += contador;
            }

            Console.WriteLine("A soma de todos números listados é = " + soma);

        }
    }
}
