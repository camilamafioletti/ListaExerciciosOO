namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();  

            Console.Write("Digite a quilometragem(km) inicial: ");
            carro.inicio = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem(km) final: ");
            carro.final = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível em litros(l): ");
            carro.consumo = double.Parse(Console.ReadLine());

            Console.WriteLine($"O consumo de combustível por km foi de: {carro.CalcularConsumo().ToString("F2")} litros/km");
            Console.ReadLine();
        }
    }
}