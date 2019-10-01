using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Calculo do IMC(Índice de Massa Corporal)");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            Console.Write("Digite o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Abaixo do peso. " +
                    "E seu risco de saúde: Muito Alto.");
            }
            else if (imc <= 25)
            {
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Peso normal. " +
                    "E seu risco de saúde: Baixo.");
            }
            else if (imc <= 30)
            {
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Pré-obesidade. " +
                    "E seu risco de saúde: Médio.");
            }
            else if (imc <= 35)
            {
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Obesidade Grau I. " +
                    "E seu risco de saúde: Alto.");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Obesidade Grau II. " +
                    "E seu risco de saúde: Muito Alto.");
            }
            else
                Console.WriteLine("Seu IMC é '" + imc.ToString("F") + "'. Sua classificação: Obesidade Grau III. " +
                    "E seu risco de saúde: Muitíssimo Alto.");

            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
            Console.ReadKey();
        }
    }
}
