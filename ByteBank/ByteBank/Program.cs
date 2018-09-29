using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }
        public static void InnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

        }
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
           // Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
        public static void Metodo()
        {
                TestaDivisao(0,0);
        }
        public static void TestaDivisao(int divisor, int numero)
        {
            try
            {
                Dividir(numero, divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro na divisão com os número= "+ numero + " e divisor= "+ divisor);
                throw;
            }

            
        }
    }
}
