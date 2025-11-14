namespace ProjetoRevisaoPOO
{
    abstract class Conta
    {
        public double  saldo { get; protected set; }
        public int numeroConta { get; set; }
        public int agencia { get; set; }
        public Cliente cliente { get; set; }

        public Conta(int numeroConta, int agencia, Cliente cliente)
        {
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.cliente = cliente;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public abstract void Sacar(double valor);
        
        

    }





}
