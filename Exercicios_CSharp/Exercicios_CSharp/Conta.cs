using System;

namespace Exercicios_CSharp
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Transferir(double valor,
                               Conta destino)
        {
            if (this.Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }
    }
}
