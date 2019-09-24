using System;

namespace Exercicios_CSharp2
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string cpf;
        public string rg;
        public string endereco;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;

        } 
    }
}