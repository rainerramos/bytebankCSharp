

using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }

        public int Numero { get; }             
        public int Agencia { get; }  
           
        
        private double _saldo = 100;
        public double Saldo
        {
            get //get vai sempre retornar
            {
                return _saldo;
            }
            set //set vai definir o nosso saldo. 
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero) //CONSTRUTOR
        {
           if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.");
            }

           if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.");
            }

            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor) // void quer dizer que essa função não tem retorno, não devolve nada
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}

