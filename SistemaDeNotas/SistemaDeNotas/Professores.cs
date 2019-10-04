namespace SistemaDeNotas
{
    class Professores : Funcionarios
    {
        public int RegistroProfessor { get; set; }
        public string DisciplinaMinistrada { get; set; }

        public override void ReceberSalario()
        {
            //faço minha forma
        }

    }
}
