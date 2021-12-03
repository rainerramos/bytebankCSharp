

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this.saldo = saldo;

        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            return true;

        }

        public void Depositar(double valor) // void quer dizer que essa função não tem retorno, não devolve nada
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}

