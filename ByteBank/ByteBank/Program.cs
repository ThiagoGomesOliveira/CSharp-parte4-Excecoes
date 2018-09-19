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
            catch (DivideByZeroException e)
            {
               Console.WriteLine("Não é possivel dividir por zero");

            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }


        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
           // Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
        public static void Metodo()
        {
                TestaDivisao(0,10);
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
