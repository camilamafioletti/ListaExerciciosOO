namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Temperatura temperatura = new Temperatura();

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperatura.celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperatura.ConvertendoGrausCelsius().ToString("F2") + "°F.");
        }
    }
}