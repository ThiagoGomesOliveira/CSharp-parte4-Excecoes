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



        private int _agencia;
        public int Agencia { get; }
        
         
        private int _conta;
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
                this._saldo -= valor;
            }

        }

        private bool VerificarSaldo(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            return true;
        }


        public void Transferir(double valor, ContaCorrente conta)
        {
            if (VerificarSaldo(valor))
            {
                this._saldo -= valor;
                conta.Depositar(valor);
            }
        }

    }

}
