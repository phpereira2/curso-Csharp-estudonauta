using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int fim = 0;

            Console.SetCursorPosition(0,1);
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("-----------------------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out inicio);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);
            Console.WriteLine("-----------------------------------");
            Console.Write("Sorteando...");
            Thread.Sleep(2000);
            Console.SetCursorPosition(0, 6);
            Random rand = new Random();
            int sorteio = rand.Next(inicio, fim);
            Console.WriteLine($"Entre {inicio} e {fim} sorteei o valor {sorteio}");
            Console.ReadKey();
        }
    }
}
