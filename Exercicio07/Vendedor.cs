namespace Exercicio07
{
    public class Vendedor
    {

        public double salarioBase {get; set;}
        public double total {get; set;}
        public double comissao {get; set;}

        public double CalcularSalario()
        {
            return salarioBase + (total * (comissao / 100));
        }

    }
}
