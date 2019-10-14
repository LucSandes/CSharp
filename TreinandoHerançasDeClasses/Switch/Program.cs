using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 2;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Erro de digitação!");
                    break;
            }

            Combustivel c = Combustivel.Querosene;

            switch (c)
            {
                case Combustivel.Gás:
                    Console.WriteLine("Gás");
                    break;
                case Combustivel.Diesel:
                    Console.WriteLine("Diesel");
                    break;
                case Combustivel.Alcool:
                    Console.WriteLine("Alcool");
                    break;
                case Combustivel.Gasolina:
                    Console.WriteLine("Gasolina");
                    break;
                case Combustivel.Querosene:
                    Console.WriteLine("Querosene");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }

    enum Combustivel
    {
        Gás,
        Diesel,
        Alcool,
        Gasolina,
        Querosene
    }
}
