using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valor, salario;

            Console.WriteLine("Digite o número do funcionário: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;

            Console.WriteLine("Número = " + numero);
            Console.WriteLine("Salário = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}