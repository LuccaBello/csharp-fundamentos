using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split(' ');

            double x = double.Parse(val[0]);
            double y = double.Parse(val[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }

            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }

            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }

            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }

            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}