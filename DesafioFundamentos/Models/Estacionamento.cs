using System.Runtime.InteropServices;

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
            
            
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string AdicionarPlaca;
            AdicionarPlaca = Console.ReadLine();
            veiculos.Add(AdicionarPlaca);
            Console.Clear();
            Console.WriteLine("Placa adicionada com sucesso.");
            
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            Console.Clear();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Int32.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 


                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("_____________________________");

            // Lista todos os elementos dentro da lista atraves do laço
                for (int Contador = 0; Contador < veiculos.Count; Contador++){
                    Console.WriteLine($"{Contador}: {veiculos[Contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
