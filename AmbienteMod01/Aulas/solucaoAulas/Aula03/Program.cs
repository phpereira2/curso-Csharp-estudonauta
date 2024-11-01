using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program
    {
        /// <summary>
        /// Método executado automaticamente ao apertar Iniciar
        /// ou executar diretamente pela linha de comando
        /// </summary>
        /// <param name="args">É um vetor que pode conter parâmetros de execução
        /// do meu programa.</param>
        /// <returns>Esse método não efetua retorno</returns>
        /// <example>
        /// <code>
        ///     Podemos executar um Program.exe ....
        /// </code>
        /// </example>
        static void Main(string[] args)
        {
            // Comentário de uma única linha

            /*
              Isso aqui é um comentário
              que vai ficar em várias
              linhas de código
            */

            /*
             * Ele pode ser mais estiloso,
             * colocando um asterisco em cada
             * linha digitada
            */

            Console.WriteLine("Olá, mundo!"); // Me livrei da maldição :)
            Console.WriteLine("Testando comentários!");
            Console.ReadKey();
        }
    }
}
