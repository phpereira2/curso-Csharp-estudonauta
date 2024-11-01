using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(4, 50);
            Console.Write("Acabei de gerar o número: " + n);
            Console.ReadKey();
        }
    }
}
