using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão Implícita int->float
            /*
              int a = 8;
              float b = a;  
            */
            // Conversão Explícita float->int
            /*
              float a = 8.9999f;
              int b = (int)a;
            */
            // Conversão por Classes Auxiliares
            float a = 8.502f;
            int b = Convert.ToInt16(a);

            Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de a é " + b + " do tipo " + b.GetType());
            Console.ReadKey();
        }
    }
}
