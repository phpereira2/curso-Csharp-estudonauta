using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual é o seu sslário? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"Você ganha {sal:C} por mês!");
            Console.ReadKey();
        }
    }
}
