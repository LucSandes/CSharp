namespace SistemaDeNotas
{
    class Professores : Pessoa
    {
        public string DataAdmisso { get; set; }
        public string DataDemissao { get; set; }
        public int RegistroProfessor { get; set; }
        public string DisciplinaMinistrada { get; set; }
        public double Salario { get; set; }
    }
}
