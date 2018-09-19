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
            try
            {
                Metodo();
            }
            catch (DivideByZeroException erro)
            {

               Console.WriteLine(erro.Message);
               Console.WriteLine(erro.StackTrace);
            }
           
            Console.ReadLine();
        }


        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
        public static void Metodo()
        {
            
            try
            {
                TestaDivisao(2);
            }
            catch (NullReferenceException erro)
            {

                Console.WriteLine(erro.Message);
            }
           
        }

        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
