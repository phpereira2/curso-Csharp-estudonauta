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
            // Entrada de dados
            float n1 = 0f;
            float n2 = 0f;
            Console.Write("Digite nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);

            // Calculo da média e situações
            float média = (n1 + n2) / 2;
            bool sit01 = média >= 0.0 && média < 4.0;
            bool sit02 = média >= 4.0 && média < 7.0;
            bool sit03 = média >= 7.0 && média < 10.0;

            // Mostrando resultados
            Console.WriteLine($"A média do aluno foi {média:F1}");
            Console.WriteLine($"Aluno está reprovado? {sit01}");
            Console.WriteLine($"Aluno está em recuperação? {sit02}");
            Console.WriteLine($"Aluno está aprovado? {sit03}");
            Console.ReadKey();
        }
    }
}