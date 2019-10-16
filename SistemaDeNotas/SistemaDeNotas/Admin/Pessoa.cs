using System;

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

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
