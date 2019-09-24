namespace Banco
{
    public class TotalizadorDeContas : Conta
    {
        public double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
            conta.CalculaRendimento();
        }
    }
}
