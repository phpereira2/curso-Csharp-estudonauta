using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ESCOLA = "Estudonauta";
            const float PI = 3.1415f;

            // escola = "CursoemVídeo"; // Comando dá erro!

            Console.WriteLine("Eu estudo no " + ESCOLA);
            Console.WriteLine("O Valor de Pi é " + PI);
            Console.WriteLine("O valor OFICIAL de Pi é " + Math.PI);
            Console.WriteLine("O tipo de PI no meu programa é " + PI.GetType());
            Console.WriteLine("O tipo de PI em Math é " + Math.PI.GetType());
            Console.ReadKey();
        }
    }
}
