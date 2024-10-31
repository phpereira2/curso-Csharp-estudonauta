using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int dia = DateTime.Now.Day;
            Console.WriteLine("A data atual é " + dia + " do mês " + mes + " do ano " + ano);
            Console.ReadKey();

            int hora = DateTime.Now.Hour;
            int minuto  = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;
            Console.WriteLine("E a hora atual é " + hora + " no minuto " + minuto + " no segundo " + segundo);
            Console.ReadKey();
        }
    }
}
