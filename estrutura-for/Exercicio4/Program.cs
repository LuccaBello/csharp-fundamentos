using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);

                if (valor2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                else
                {
                    double divisao = (double)valor1 / valor2;
                    Console.WriteLine(divisao.ToString("F1"), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}