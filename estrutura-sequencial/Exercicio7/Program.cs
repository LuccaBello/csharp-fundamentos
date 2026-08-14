using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi;
            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

            circulo = pi * (c * c);
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));

            trapezio = (a + b) * c / 2;
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            quadrado = b * b;
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

            retangulo = a * b;
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}