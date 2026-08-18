using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Cadeira";
            string produto2 = "Mesa";
            double preco1 = 599.90;
            double preco2 = 1299.50;

            double largura = 1.25678;
            double comprimento = 2.34567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1} - {preco1:F2}");
            Console.WriteLine($"{produto2} - {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine("Dimensões: ");
            Console.WriteLine();
            Console.WriteLine($"Largura: {largura} m");
            Console.WriteLine($"Comprimento: {comprimento} m");
            Console.WriteLine();
            Console.WriteLine($"Largura arredondada: {largura:F2} m");
            Console.WriteLine($"Comprimento arredondado: {comprimento:F2} m");
            Console.WriteLine();
            Console.WriteLine("Valores usando InvariantCulture: ");
            Console.WriteLine("Largura: " + largura.ToString("F2", CultureInfo.InvariantCulture) + " m");
            Console.WriteLine("Comprimento: " + comprimento.ToString("F2", CultureInfo.InvariantCulture) + " m");
        }
    }
}