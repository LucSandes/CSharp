using System;

namespace SistemaDeNotas
{
    public class Funcionario : Pessoa
    {
        public DateTime admissao;
        public DateTime demissao;
        public int FregistroFuncionario;
        public string cargo;
        public double salario;

        public DateTime Admissao { get; set; }
        public DateTime Demissao { get; set; }
        public int RegistroFuncionario { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public virtual void ReceberSalario()
        {
            //faço a forma de receber salário
        }
    }
}
