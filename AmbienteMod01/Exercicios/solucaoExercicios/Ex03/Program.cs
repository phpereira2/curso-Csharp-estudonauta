using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número Real: ");
            float num = 0;
            float.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Você digitou o valor {num:N3}");
            int numInt = (int)num;
            Console.WriteLine($"A parte inteira do número é {numInt}");
            int numFloat = Convert.ToInt16(num);
            Console.WriteLine($"Arredondando, temos o número {numFloat}");
            Console.ReadKey();
        }
    }
}
