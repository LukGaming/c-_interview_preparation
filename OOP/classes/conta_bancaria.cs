using System;

namespace POO.classes
{
    class ContaBancaria
    {
        private double Saldo { get; set; }
        private string NumeroDaConta { get; set; }

        public ContaBancaria(double saldo, string numeroDaConta)
        {
            this.Saldo = saldo;
            this.NumeroDaConta = numeroDaConta;
        }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (this.Saldo > valor)
            {
                throw (new Exception("Saldo insuficiente"));
            }

            this.Saldo -= valor;
        }

    }
}