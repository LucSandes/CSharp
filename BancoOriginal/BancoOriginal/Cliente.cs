namespace BancoOriginal
{
    internal class Cliente
    {
        private object documentos;

        public string Nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }


        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var MaiorDeIdade = this.idade >= 18;
                var emancipado = documentos.contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (MaiorDeIdade || emancipado) && possuiCPF;
            }
        }
    }
}