﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite ao lado um número: ");
            int.TryParse(Console.ReadLine(), out n);
            int d = n * 2;
            Console.WriteLine("O dobro de " + n + " é " + d);
            Console.ReadKey();
        }
    }
}
