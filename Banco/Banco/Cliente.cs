using System.Collections.Generic;

namespace Banco
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> Documentos { get; set; }
        public string cpf { get; set; }
        public Cliente(string p)
        {
            this.Nome = p;
        }
        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.Idade >= 18;
                var emancipado = this.Documentos.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }
    }
}