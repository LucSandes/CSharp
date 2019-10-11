using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p;
            p.x = 10;
            p.y = 3;

            Console.WriteLine("({0}, {1})", p.x, p.y);

            Console.ReadKey();
        }
    }

    /*
     //Tipo:
     public - qualquer código em qualquer assembly tem acesso ao tipo;
     internal - somente código do mesmo assembly tem acesso ao tipo;
     protected - somente em tipos que estão dentro de outros tipos;
     protected internal - somente em tipos que estão dentro de outros tipos;
     private - somente em tipos que estão dentro de outros tipos;
    */
      
    /*
     //Membro de Tipo
     public - o membro pode ser acessado por código de qualquer assembly;
     internal - o membro pode ser acessado por código do mesmo assembly;
     protected - o membro pode ser acessado por código de tipos derivados;
     protected internal - combinação de protected e internal
     private - o membro só pode ser acessado no próprio tipo;
    */

    struct Ponto //se não declarou, por padrão é internal
    {
        //se não declarou, por padrão é private
        internal int x;
        internal int y;

    }
}
