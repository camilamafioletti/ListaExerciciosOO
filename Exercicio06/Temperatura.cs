namespace Exercicio06
{
    public class Temperatura
    {
        public double celsius { get; set; }

        public double ConvertendoGrausCelsius()
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
