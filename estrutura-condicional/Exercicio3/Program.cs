using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            int resto1 = a % b; 
            int resto2 = b % a;

            if (resto1 == 0 || resto2 == 0) {
                Console.WriteLine("Sao Multiplos");
            }

            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}