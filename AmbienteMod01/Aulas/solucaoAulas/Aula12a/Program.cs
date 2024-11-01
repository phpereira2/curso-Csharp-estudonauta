﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Tudo bem?");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.WriteLine($"Hoje é {dia} de {mes} do ano de {ano}");
            Console.ReadKey();
        }
    }
}
