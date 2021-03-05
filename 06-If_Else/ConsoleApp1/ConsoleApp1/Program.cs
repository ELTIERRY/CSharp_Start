using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3, B = 5, C = 7, D = 8, E = 21, F = 32;

            /*--------Comparação simples---------------------*/
            if (A < B) 
            {
                Console.WriteLine("A é menor que B");
            }
            /*-----------------------------------------------------------*/



            /*--------Comparação. Caso não satisfaça o "if", executa o "else"-------*/
            if (C > D)
            {
                Console.WriteLine("Nada"); 
            }
            else // Não necssita de comparação entre parênteses ()
            {
                Console.WriteLine("C não é maior que D");
            }
            /*-----------------------------------------------------------*/


            /*--------Comparação. Caso não satisfaça o "if", testa o "else if"-------*/
            if (E == F)
            {
                Console.WriteLine("Nada ocorre aqui");
            }
            else if (E != F)
            {
                Console.WriteLine("E diferente de F");
            }
            /*-----------------------------------------------------------*/


            /*--------Comparação. Caso não satisfaça o "if", testa o "else if", 
            caso não satisfaçam será executado o else-------*/
            if (A >= F)
            {
                Console.WriteLine("Nada ocorre aqui");
            }
            else if (E == F)
            {
                Console.WriteLine("Nada ocorre aqui");
            }
            else 
            {
                Console.WriteLine("Sem comparação entre A e F");
            }
            /*-----------------------------------------------------------*/


            Console.ReadLine();
        }
    }
}
