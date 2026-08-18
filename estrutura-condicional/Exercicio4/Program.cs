using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jogo = Console.ReadLine().Split(' ');
            int comeco = int.Parse(jogo[0]);
            int fim = int.Parse(jogo[1]);

            int duracao;

            if (comeco < fim) {
                duracao = fim - comeco;
            }

            else {
                duracao = 24 - comeco + fim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}