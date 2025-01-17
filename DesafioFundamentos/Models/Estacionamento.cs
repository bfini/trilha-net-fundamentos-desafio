using System.Text.RegularExpressions;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            //DONE: Pedir para o usuário digitar uma placa e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa= Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine ($"Desculpe, o veículo {placa} já está estacionado aqui. Confira se digitou a placa corretamente");
            }
            else if (placa == "")
            {
                Console.WriteLine("Desculpe, a placa do veículo não pode ser vazia");
            }
            else
            {
                veiculos.Add (placa);
            }
        }

        public void RemoverVeiculo()
        {
            //DONE: Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                //DONE: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32 (Console.ReadLine());
                                
                //DONE: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                decimal valorTotal = precoInicial+(precoPorHora*horas);
                
                //DONE: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
        
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //DONE: Realizar um laço de repetição, exibindo os veículos estacionados
                
                 foreach (string veiculosEstacionados in veiculos)
                 {
                     Console.WriteLine (veiculosEstacionados);
                 }              
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}