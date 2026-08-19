using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double media = 0.0;

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}