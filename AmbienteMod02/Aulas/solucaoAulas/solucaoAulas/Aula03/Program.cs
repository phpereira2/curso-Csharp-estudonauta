using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de operadores aritméticos
            int op1 = 0;
            int op2 = 0;
            // Entrada de dados
            Console.Write("Digite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo operando: ");
            int.TryParse(Console.ReadLine(), out op2);
            // Realizando as operações
            Console.WriteLine($"Calculando +{op1} = {+ op1}"); // Identidade
            Console.WriteLine($"Calculando -{op1} = {- op1}"); // Negação Aritmética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); // Adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // Subtração
            Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}"); // Multiplicação
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2} (Divisão Inteira)"); // Divisão (Inteira)
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {(float)op1 / op2:F1} (Divisão Real)"); // Divisão (Real)
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}"); // Resto da Divisão Inteira
            Console.ReadKey();
        }
    }
}