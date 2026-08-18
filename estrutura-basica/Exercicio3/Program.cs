using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Lucca Bello";
            string cidade = "Belo Horizonte";
            int idade = 24;
            double altura = 1.80;
            char sexo = 'M';

            Console.WriteLine("Dados Pessoais: ");
            Console.WriteLine();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura:F2} m");
            Console.WriteLine($"Sexo: {sexo}");
        }
    }
}