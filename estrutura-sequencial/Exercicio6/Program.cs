using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, numeroPecas1, codigo2, numeroPecas2;
            double valor1,valor2, total;

            Console.WriteLine("Digite o código, a quantidade e o valor da primeira peça (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            numeroPecas1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código, a quantidade e o valor da segunda peça (mesma linha): ");
            vet = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet[0]);
            numeroPecas2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = numeroPecas1 * valor1 + numeroPecas2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}