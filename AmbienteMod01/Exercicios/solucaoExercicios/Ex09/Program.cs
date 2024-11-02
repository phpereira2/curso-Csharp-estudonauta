using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cabeçalho1 = "Produto";
            string cabeçalho2 = "Preço";

            float preço1 = 0;
            float preço2 = 0;

            Console.SetCursorPosition(0, 2);
            Console.Write("Produto 1: ");
            string produto1 = Console.ReadLine();
            Console.Write("Preço 1: R$");
            float.TryParse(Console.ReadLine(), out preço1);
            Console.Write("Produto 2: ");
            string produto2 = Console.ReadLine();
            Console.Write("Preço 2: R$");
            float.TryParse(Console.ReadLine(), out preço2);

            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($" {cabeçalho1, -20}");
            Console.WriteLine($"{cabeçalho2, 20} ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($"{produto1, -20}");
            Console.WriteLine($"{preço1, 22:C}");
            Console.Write($"{produto2, -20}");
            Console.WriteLine($"{preço2 ,22:C}");
            Console.ReadKey();
        }
    }
}
