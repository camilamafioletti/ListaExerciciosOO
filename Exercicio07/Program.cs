namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor(); 

            Console.Write("Digite o salário do vendedor: ");
            vendedor.salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            vendedor.total = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão a ser aplicada sobre as vendas (em %): ");
            vendedor.comissao = double.Parse(Console.ReadLine());

            Console.WriteLine("O salário total do vendedor é: R$ {0:N2}", + vendedor.CalcularSalario());
        }
    }
}