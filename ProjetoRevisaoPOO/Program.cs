using ProjetoRevisaoPOO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o cpf do cliente: ");
            string cpf = Console.ReadLine();
            Cliente cliente = new Cliente(nome,cpf);
            Console.WriteLine($"antes do Json, Nome: {cliente.Nome}, cpf: {cliente.Cpf}");
            Console.WriteLine("serializando (Json)");
            string JsonString = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            Console.WriteLine($"após serializaçao:\n {JsonString}");
            Console.WriteLine("Processo reverso, Pegando um cliente de fora");
            string JsonQueVeioDaInternet = "{\"Nome\":\"Bruno Costa\",\"Cpf\":\"333.333.333-33\"}";
            Console.WriteLine($"Json que veio de fora: {JsonQueVeioDaInternet}");
            Cliente novoCliente = JsonConvert.DeserializeObject<Cliente>(JsonQueVeioDaInternet);
            Console.WriteLine($"Resultado da Deserializção: \n nome:{novoCliente.Nome}, cpf: {novoCliente.Cpf}");







        }
    }
}
