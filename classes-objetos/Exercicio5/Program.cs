using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaTotal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.NotaTotal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double restante = 60 - aluno.NotaTotal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + restante.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}