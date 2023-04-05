namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo();   

            Console.WriteLine("Digite a altura da lata em cm: ");
            lataDeOleo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio da lata em cm: ");
            lataDeOleo.raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"O volume da lata é {lataDeOleo.CalcularVolume():F2} centímetros cúbicos.");
        }
    }
}