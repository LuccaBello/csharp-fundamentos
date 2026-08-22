using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência: " 
                + Calculadora.Circunferencia(r).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " 
                + Calculadora.Volume(r).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}