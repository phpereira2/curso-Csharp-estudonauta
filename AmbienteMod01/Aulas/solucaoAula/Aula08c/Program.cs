using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite ao lado um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = n * 2;
            Console.WriteLine("O dobro de " + n + " é " + d);
            Console.ReadKey();
        }
    }
}
