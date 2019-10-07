namespace SistemaDeNotas
{
    class Funcionarios : Alunos
    {
        public string DataAdmissao { get; set; }
        public string DataDemissao { get; set; }
        public int RegistroFuncionario { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public virtual void ReceberSalario()
        {

        }
    }
}
