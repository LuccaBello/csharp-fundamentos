using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto = "Notebook";
            double preco = 3499.90;
            int quantidade = 3;
            char categoria = 'A';

            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço unitário: $ {preco:F2}");
            Console.WriteLine($"Quantidade disponível: {quantidade}");
            Console.WriteLine($"Categoria: {categoria}");

        }   
    }
}