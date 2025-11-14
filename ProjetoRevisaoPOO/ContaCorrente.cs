namespace ProjetoRevisaoPOO
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
        }


        public override void Sacar(double valor)
        {
            double taxa = 15;
            if (valor + taxa <= this.saldo)
            {
                saldo -= valor + taxa;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
            }
        }
    }
}
