using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            float altura = 0f;
            Console.Write("Qual é a sua altura?");
            float.TryParse(Console.ReadLine(), out altura);

            // Verificação de status
            string status = (altura <= 1.70) ? "baixa" : "alta";

            // Mostrar resultado
            Console.WriteLine($"Alguém com {altura:F2}m de altura é considerado uma pessoa {status}!");
            Console.ReadKey();
        }
    }
}