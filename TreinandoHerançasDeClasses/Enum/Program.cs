using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //char c = 'F';
            Sexo s = Sexo.masculino;

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }

    enum Sexo
    {
        //Enum é uma lista de opções
        masculino, //0
        feminino   //1
    }

    enum Estacoes
    {
        summer,        //0
        winter,        //1
        spring,        //2
        fall,          //3
        autumn = fall  //3
    }

    enum EstadoCivil
    {
        solteiro = 10,
        casado = 7,
        divorciado = 100,
        viuvo = 0,
        outros = 5
    }
}
