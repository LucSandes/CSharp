namespace SistemaDeNotas
{
    class Funcionarios : Pessoa
    {
        public string DataAdmissao { get; set; }
        public string DataDemissao { get; set; }
        public int RegistroFuncionario { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}
