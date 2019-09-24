namespace BancoOriginal
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        internal Cliente Titular { get; set; }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        internal virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
