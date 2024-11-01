using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            float sal = 550.7556f;
            int idade = 22;
            Console.WriteLine($"O {nome, -10} tem {idade, -5:D3} anos e ganha {sal, 20:C2} por mês.");
            int num = 13;
            Console.WriteLine($"O número foi {num:X}.");
            float val = 44679.003f;
            Console.WriteLine($"O valor foi {val:E}.");
            Console.ReadKey();
        }
    }
}
