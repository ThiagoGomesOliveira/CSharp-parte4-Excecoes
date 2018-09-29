using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaldo { get; }

        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string pMensagem)
            : base(pMensagem)
        {

        }

        public SaldoInsuficienteException(double pSaldo, double pValorSaldo)
            :this("Tentativa de saque " + pSaldo + " com saldo de  "+ pValorSaldo)
        {
            this.Saldo = pSaldo;
            this.ValorSaldo = pSaldo;
        }
    }
}
