namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0; // valor da entrada no estacionamento
        private decimal precoPorHora = 0; // valor por hora que o cliente vai ficar no estacionamento
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() // Metodo para inserir um Veículo no estacionamento
        {

            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com a placa {placa} cadastrado com sucesso");
        }

        public void RemoverVeiculo() // Metodo para liberar um Veículo no estacionamento
        {
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");


                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = (precoInicial + precoPorHora) * horas;


                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi liberado para saida com o preço total de: R$ {valorTotal} Reais");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos() // // Metodo para listar os Veículos no estacionamento
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                int contadorForeach = 0;
                foreach (string placas in veiculos)
                {
                    Console.WriteLine($"{placas}");
                    contadorForeach++;
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
