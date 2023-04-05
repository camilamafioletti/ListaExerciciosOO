namespace Exercicio08
{
    public class LataDeOleo
    {
        public double raio { get; set; }
        public double altura { get; set; }

        public double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;
        }

    }
}
