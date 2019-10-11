using System;

namespace SistemaDeNotas
{
    public class Funcionarios : Pessoa
    {
        private DateTime admissao;
        private DateTime demissao;
        private int FregistroFuncionario;
        private string cargo;
        private double salario;

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
