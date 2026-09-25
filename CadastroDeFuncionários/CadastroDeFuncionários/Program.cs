using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace CadastroDeFuncionários
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            char opcao = '0';
            
            Console.WriteLine("===== SISTEMA DE FUNCIONÁRIOS =====");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Consultar funcionário");
            Console.WriteLine("3 - Aumentar salário");
            Console.WriteLine("4 - Exibir salário líquido");
            Console.WriteLine("5 - Sair");

            while (opcao != '5') {
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == '1')
                {
                    Console.Write("Nome: ");
                    func.Nome = Console.ReadLine();
                    Console.Write("Salario bruto: ");
                    func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Imposto: ");
                    func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                else if (opcao == '2')
                {
                    Console.WriteLine("===== FUNCIONÁRIO =====");
                    Console.WriteLine();
                    Console.WriteLine("Nome: " + func.Nome);
                    Console.WriteLine("Salário bruto: R$ " + func.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Imposto: R$ " + func.Imposto.ToString("F2", CultureInfo.InvariantCulture));
                }

                else if (opcao == '3')
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    func.AumentarSalario(pct);
                    Console.WriteLine("Salário atualizado: R$ " + func.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
                }

                else if (opcao == '4')
                {
                    Console.WriteLine("Salário líquido: R$ " + func.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
                }

                else if (opcao == '5')
                {
                    Console.WriteLine("Programa encerrado.");
                }
            }
        }
    }
}