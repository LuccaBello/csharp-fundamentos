using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiro, segundo;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            primeiro.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiro.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            segundo.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundo.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (primeiro.Salario + segundo.Salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}