using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string _cpf;
        public string Cpf
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        public string _profissao;
        public string Profissao
        {
            get
            {
                return this._profissao;
            }
            set
            {
                this._profissao = value;
            }
        }


    }
}
