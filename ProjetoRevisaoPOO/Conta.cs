namespace ProjetoRevisaoPOO
{
    abstract class Conta
    {
        public decimal  Saldo { get; protected set; }
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public Cliente Cliente { get; set; }

        public Conta(int numeroConta, int agencia, Cliente cliente)
        {
            this.NumeroConta = numeroConta;
            this.Agencia = agencia;
            this.Cliente = cliente;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public abstract bool Sacar(decimal valor);

        public void Transferir(decimal valor, Conta contaRecebe)
        {
            bool saqueFunciona =this.Sacar(valor);
            if (saqueFunciona == true)
            {
                contaRecebe.Depositar(valor);
            }

        }
        
        

    }





}
