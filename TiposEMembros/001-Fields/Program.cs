using System;

namespace _001_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao fracao;
            fracao.numerador = 1;
            fracao.denominador = 2;

            Console.WriteLine("{0}/{1}", fracao.numerador, fracao.denominador);

            Ponto p = new Ponto();

            p.x = 10;
            p.y = 5;

            Console.WriteLine("({0}, {1})", p.x, p.y);

            Console.ReadKey();

        }
    }

    //values types - struct e enum
    //reference types - class e delegate

    /*membros: 
     * fields -> campo é private
     * properties -> expõe os fields através de métodos get(faz a leitura) e set(faz a escrita)
     * method -> contém inteligência, funcionalidades do tipo
     * constructor -> tipo de método, responsável por inicializar o objeto, chamado apenas pelo operador 'new'
     * events -> notificação lançada pelo tipo
    */

    /*por padrão se não escreve vem como internal*/
    struct Fracao
    {
        //internal indica que o membro(field) é acessado por qualquer código dentro do assembly
        internal int numerador; //deveria ser private
        internal int denominador; //deveria ser private
    }

    /*por padrão se não escreve vem como internal*/
    class Ponto
    {
        internal int x; //deveria ser private
        internal int y; //deveria ser private
    }
}
