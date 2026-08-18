using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int resto = num % 2;

            if (resto == 0) {
                Console.WriteLine("PAR");
            }

            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}