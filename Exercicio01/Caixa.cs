namespace Exercicio01
{
    public class Caixa
    {
        public double comprimento { get; set; }
        public double largura { get; set; }
        public double altura { get; set; }
        public double volume { get; set; }

        public double CalcularVolume()
        {
            return volume = altura * largura * comprimento;
        }

    }
}
