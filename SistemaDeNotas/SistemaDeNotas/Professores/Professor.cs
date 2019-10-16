namespace SistemaDeNotas
{
    public class Professor : Funcionario
    {
        public int registroProfessor;
        public string disciplinaMinistrada;

        public int RegistroProfessor
        {
            get => registroProfessor; set => registroProfessor = value;
        }
        public string DisciplinaMinistrada
        {
            get => disciplinaMinistrada; set => disciplinaMinistrada = value;
        }

        public override void ReceberSalario()
        {
            //sobrescrever a forma de receber salário
        }
    }
}
