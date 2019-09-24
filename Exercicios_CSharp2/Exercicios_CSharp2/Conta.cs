using System;

namespace Exercicios_CSharp2
{
    public class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

        public double PegaSaldo()
        {
            return this.Saldo;
        }

        public void ColocaNumero(int numero)
        {
            this.Numero = numero;
        }
    }
}
