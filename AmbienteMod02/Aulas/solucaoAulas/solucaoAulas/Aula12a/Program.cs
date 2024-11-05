using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite um número em base decimal: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase:2)} em Binário.");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 8)} em Octal.");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 16)} em Hexadecimal.");
        }
    }
}