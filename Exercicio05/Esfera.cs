namespace Exercicio05
{
    public class Esfera
    {
        public int raio { get; set; }

        public double CalcularVolume()
        {
            return 4 * Math.PI * Math.Pow(raio, 3) / 3;
        }
    }
}
