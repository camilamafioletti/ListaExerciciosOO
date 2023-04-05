namespace Exercicio03
{
    public class Cilindro
    {
        public double raio { get; set; }
        public double altura { get; set; }

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}

