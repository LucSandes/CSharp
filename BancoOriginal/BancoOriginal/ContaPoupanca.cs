namespace BancoOriginal
{
    class ContaPoupanca : Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        internal override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }
    }
}
