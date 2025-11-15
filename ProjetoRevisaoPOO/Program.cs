using ProjetoRevisaoPOO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu cpf: ");
            string cpf = Console.ReadLine();
            Cliente cliente = new Cliente(nome,cpf);
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da agência: ");
            int agencia = int.Parse(Console.ReadLine());
            ContaCorrente conta1 = new ContaCorrente(numConta, agencia,cliente);
            ContaPoupanca conta2 = new ContaPoupanca(numConta,agencia,cliente);
            Console.Write("Digite o valor do deposito: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            conta1.Depositar(valor);
            conta2.Depositar(valor);
            Console.WriteLine($"Saldo conta 1 {conta1.Saldo}");
            Console.WriteLine($"Saldo conta 2 {conta2.Saldo}"); 
            Console.Write("Digite o valor do saque: ");
            valor = decimal.Parse(Console.ReadLine());
            conta1.Sacar(valor);
            conta2.Sacar(valor);
            Console.WriteLine($"Saldo conta 1 {conta1.Saldo}");
            Console.WriteLine($"Saldo conta 2 {conta2.Saldo}");
            Console.Write("Digite o valor da tranferencia da conta 1 para conta 2: ");
            valor = decimal.Parse(Console.ReadLine());
            conta1.Transferir(valor, conta2);
            Console.WriteLine($"Saldo conta 1 {conta1.Saldo}");
            Console.WriteLine($"Saldo conta 2 {conta2.Saldo}");







        }
    }
}
