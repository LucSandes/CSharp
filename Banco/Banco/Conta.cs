using System;

namespace Banco
{
    public class Conta
    {

        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }
        public Conta() { }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public abstract void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public abstract void Saca(double valor)
        {
            this.Saldo -= valor;

        }

        internal void CalculaRendimento()
        {
            throw new NotImplementedException();
        }
    }
}