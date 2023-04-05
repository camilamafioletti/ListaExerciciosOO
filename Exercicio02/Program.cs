namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.WriteLine("Entre com a temperatura em fahrenheit: ");
            temperatura.fahrenheit = double.Parse(Console.ReadLine());

            temperatura.celsius = (temperatura.fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura convertida em celsius: " + temperatura.celsius.ToString("F2"));
        }
    }
}