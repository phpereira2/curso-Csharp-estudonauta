using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(7, 4);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Write(" MEU ");
            Console.ResetColor();

            Console.SetCursorPosition(12, 4);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write(" BRASIL ");
            Console.ResetColor();

            Console.SetCursorPosition(20, 4);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Write(" BRASILEIRO ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
