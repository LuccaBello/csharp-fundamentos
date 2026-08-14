using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (raio * raio);

            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}