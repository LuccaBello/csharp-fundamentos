using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int IN = 0;
            int OUT = 0;

            for (int i = 1; i <=  N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    IN++;
                }
                else
                {
                    OUT++;
                }
            }

            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");
        }
    }
}