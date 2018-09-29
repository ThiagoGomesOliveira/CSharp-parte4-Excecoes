using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int QtdContaCorrentes { get;private set; }
        public int aContadorSaquesNaoPermitidos { get; private set; }
        public int aContadorTransferenciasNaoPermitida { get; private set; }


        public ContaCorrente(int agencia, int conta)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Argumento agencia deve ser maior que zero.", nameof(agencia));
            }

            if (conta <= 0)
            {
                throw new ArgumentException("Argumento conta deve ser maior que zero.",nameof(conta));
            }
            this.Agencia = agencia;
            this.Conta = conta;
            QtdContaCorrentes++;
        }
        public int Agencia { get; }
        public int Conta { get; }
        private double _saldo;
        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value > 0)
                {
                    this._saldo = value;
                }
            }
        }
        private Cliente _titular;
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (VerificarSaldo(valor))
            {
                aContadorSaquesNaoPermitidos++;
                this._saldo -= valor;
            }

        }

        private bool VerificarSaldo(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor de saque não pode ser negativo.",nameof(valor));
            }
            if (this._saldo < valor)
            {
                throw new SaldoInsuficienteException(this._saldo,valor);
            }
            return true;
        }


        public void Transferir(double valor, ContaCorrente conta)
        {
           
            if (VerificarSaldo(valor))
            {
                try
                {
                    this.Sacar(valor);
                }
                catch (SaldoInsuficienteException e)
                {
                    aContadorTransferenciasNaoPermitida++;
                    throw new OperacaoFinanceiraException("Operação não realizada.", e);
                }
                conta.Depositar(valor);
            }
        }

    }

}
