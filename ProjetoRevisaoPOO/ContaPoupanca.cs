namespace ProjetoRevisaoPOO
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
        }


        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
            }

        }
    }
}
