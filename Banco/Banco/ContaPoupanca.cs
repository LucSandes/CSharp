namespace Banco
{
    public class ContaPoupanca : Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }

        public override void Deposita(double valor)
        {
            this.Saca(valor + 0.10);
        }

        public ContaPoupanca(int numero) : base(numero) { }

        public ContaPoupanca()
        {
        }
    }
}
