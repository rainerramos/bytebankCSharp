using _07_ByteBank;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(514, 1562);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

           // Metodo();

            Console.WriteLine("Execução Finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
            //try
            //{
            //  Console.WriteLine("TRY: inicio");
            //  TestaDivisao(0);
            //  TestaDivisao(20);
            //  Console.WriteLine("TRY: fim");
            //}
            //catch (DivideByZeroException ex)
            //{
            //  Console.WriteLine("Mensagem: " + ex.Message);
            //  Console.WriteLine("Rastro da pilha: " + ex.StackTrace);
            //  Console.WriteLine("ops, erro DivideByZeroException");
            //}
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }
            

            //catch(DivideByZeroException ex)
            //{
            //  Console.WriteLine(ex.StackTrace);
            //}

            Console.WriteLine("Estou executando normalmente!");

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                Console.WriteLine("Fazendo o cálculo " + numero + " / " + divisor);
                int resultado = numero / divisor;
                Console.WriteLine("O resultado é " + resultado);
                return resultado;   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no cálculo: " + ex.Message);
                throw; // Lançar exceção

                Console.WriteLine("Código depois do throw");
            }
        }
    }
}