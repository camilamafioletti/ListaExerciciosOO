﻿namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro(); 

            Console.Write("Digite o raio da base do cilindro em metros: ");
            cilindro.raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro em metros: ");
            cilindro.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O volume do cilindro é: " + cilindro.CalcularVolume() + " metros cúbicos.");
        }
    }
}