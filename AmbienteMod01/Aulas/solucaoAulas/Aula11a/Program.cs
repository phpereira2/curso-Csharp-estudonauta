using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula11a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Day;
            Console.Write("Hoje é dia ");
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mês ");
            Thread.Sleep(1000);
            Console.Write(mes);
            Thread.Sleep(1000);
            Console.WriteLine(" do ano ");
            Thread.Sleep(1000);
            Console.Write(ano);
            Console.ReadKey();
        }
    }
}
