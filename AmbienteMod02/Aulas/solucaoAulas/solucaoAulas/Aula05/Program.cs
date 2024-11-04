using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0f;
            float nota2 = 0f;

            Console.Write("Primeira nota: ");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Segunda nota: ");
            float.TryParse(Console.ReadLine(), out nota2);

            float média = (nota1 + nota2) / 2;
            Console.WriteLine($"As notas registradas foram {nota1:F1} e {nota2:F1}");
            Console.WriteLine($"A média do aluno foi {média:F1}");
            Console.ReadKey();
        }
    }
}