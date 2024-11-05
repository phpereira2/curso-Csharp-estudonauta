using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = true;

            Console.WriteLine($"não {p} = {!p}"); // Operador lógico NÃO
            Console.WriteLine($"{p} e {q} = {p && q}"); // Op lógico E
            Console.WriteLine($"{p} ou {q} = {p || q}"); // Op lógico OU
            Console.ReadKey();
        }
    }
}