namespace Banco.Conta
{

    public class ContaCorrente : Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public void Saca(double valor)
        {
            this.Saldo -= (valor + 0.05);
        }

        public void Deposita(double valor)
        {
            this.Saca(valor + 0.10);
        }
    }
}
