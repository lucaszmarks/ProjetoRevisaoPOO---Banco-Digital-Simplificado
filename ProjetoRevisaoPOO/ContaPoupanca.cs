namespace ProjetoRevisaoPOO
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
        }


        public override bool Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
                return false;
            }

        }
    }
}
