namespace Exercicio04
{
    public class Carro
    {
        public double consumo { get; set; }
        public double inicio { get; set; }
        public double final { get; set; }

        public double CalcularConsumo()
        {
            return (inicio - final) / consumo;
        }
    }
}
