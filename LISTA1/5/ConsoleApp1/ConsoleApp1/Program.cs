using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Digite o valor da aplicação mensal:");
                double p = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a taxa de juros (em decimal):");
                double i = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de meses:");
                int n = int.Parse(Console.ReadLine());

                double acumulado = p * ((Math.Pow(1 + i, n) - 1) / i);
                double rendimento = acumulado - (p * n);

                Console.WriteLine($"O rendimento total da poupança programada é: R$ {rendimento}");
                Console.ReadKey();
            }
        }

    }
}
