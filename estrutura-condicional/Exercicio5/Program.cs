using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split(' ');

            int codigo = int.Parse(val[0]);
            int quantidade = int.Parse(val[1]);

            double preco = 0.0;

            if (codigo == 1) {
                preco = 4.00;
            }

            else if (codigo == 2) {
                preco = 4.50;
            }

            else if (codigo == 3) {
                preco = 5.00;
            }

            else if (codigo == 4) {
                preco = 2.00;
            }

            else if (codigo == 5) {
                preco = 1.50;
            }

            double total = preco * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
    }
}