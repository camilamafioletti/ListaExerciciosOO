using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.raio = 5;

            Console.WriteLine("Volume = " + esfera.CalcularVolume().ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}