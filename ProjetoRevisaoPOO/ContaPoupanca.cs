namespace ProjetoRevisaoPOO
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numeroConta, int agencia, Cliente cliente) : base(numeroConta, agencia, cliente)
        {
        }


        public override void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
            }

        }
    }
}
