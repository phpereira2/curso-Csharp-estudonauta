using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int anoAtual = DateTime.Now.Year;
            int ano = 0;
            int.TryParse(Console.ReadLine(), out ano);
            int idade = anoAtual - ano;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Estamos atualmente no ano de {anoAtual}");
            Console.WriteLine($"Se você nasceu em {ano} vai ter {idade} anos.");
            Console.ReadKey();
        }
    }
}