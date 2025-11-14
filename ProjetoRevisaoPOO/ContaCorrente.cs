namespace ProjetoRevisaoPOO
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
        }


        public override void Sacar(decimal valor)
        {
            decimal taxa = 15;
            if (valor + taxa <= this.Saldo)
            {
                Saldo -= valor + taxa;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
            }
        }
    }
}
