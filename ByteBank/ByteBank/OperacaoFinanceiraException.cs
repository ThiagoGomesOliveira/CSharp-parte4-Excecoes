using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
   public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string pMensagem)
            :base(pMensagem)
        {

        }

        public OperacaoFinanceiraException(string pMensagem, Exception pExecaoInterna)
            :base(pMensagem,pExecaoInterna)
        {

        }

    }
}
