using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Digite um número inteiro: ");
            int.TryParse(Console.ReadLine(), out num);

            string tipo = num % 2 == 0 ? "PAR" : "ÍMPAR";

            Console.WriteLine($"O número {num:D} que você digitou é {tipo}!");
            Console.ReadKey();
        }
    }
}