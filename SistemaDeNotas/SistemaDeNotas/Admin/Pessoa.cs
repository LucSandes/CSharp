using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeNotas
{
    public class Pessoa
    {
        public string nome;
        public DateTime nascimento;
        public string endereco;
        public string telefone;
        public string email;
        public string cpf;
        public string cidade;
        public string estado;
        public string Nome { get => nome; set => nome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }

        //public Pessoa(string _nome, string _dataNascimento, string _endereco, string _telefone,
        //              string _email, string _cpf, string _cidade, string _estado)
        //{
        //    this.Nome = _nome;
        //    this.DataNascimento = _dataNascimento;
        //    this.Endereco = _endereco;
        //    this.Telefone = _telefone;
        //    this.Email = _email;
        //    this.Cpf = _cpf;
        //    this.Cidade = _cidade;
        //    this.Estado = _estado;
        //}
    }
}
