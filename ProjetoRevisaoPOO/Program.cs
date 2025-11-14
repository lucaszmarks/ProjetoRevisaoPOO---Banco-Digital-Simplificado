using ProjetoRevisaoPOO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.Write("Digite seu nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Digite seu cpf: ");
            cliente.cpf = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da agência: ");
            int agencia = int.Parse(Console.ReadLine());
            ContaCorrente conta1 = new ContaCorrente(numConta, agencia,cliente);
            ContaPoupanca conta2 = new ContaPoupanca(numConta,agencia,cliente);
            Console.Write("Digite o valor do deposito: ");
            double valor = double.Parse(Console.ReadLine());
            conta1.Depositar(valor);
            conta2.Depositar(valor);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);
            Console.Write("Digite o valor do saque: ");
            valor = double.Parse(Console.ReadLine());
            conta1.Sacar(valor);
            conta2.Sacar(valor);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);






        }
    }
}
