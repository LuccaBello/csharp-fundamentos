using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Carlos";
            double salario = 3250.75;
            int horasTrabalhadas = 160;
            double valorHora = 20.3175;

            Console.WriteLine($"Funcionário: {nome}");
            Console.WriteLine();
            Console.WriteLine($"Salário: {salario:F2}");
            Console.WriteLine($"Horas Trabalhadas: {horasTrabalhadas}");
            Console.WriteLine($"Valor da hora: {valorHora:F2}");
            Console.WriteLine();
            Console.WriteLine($"Valor da hora com quatro casas decimais: {valorHora:F4}");
        }
    }
}