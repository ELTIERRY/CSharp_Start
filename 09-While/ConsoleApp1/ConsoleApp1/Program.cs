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
            int x = 0;
            Console.Write("Digite o número de repetições... ");
            int rep = int.Parse(Console.ReadLine());

            /*--------------- Estrutura repetição While--------------*/
            while(x < rep) 
            {
                Console.WriteLine($"Repetição While nº: {x + 1}");
                x++;
            }
            /*-------------------------------------------------------*/


            /*--------------- Estrutura repetição DO... While--------------*/
            do
            {
                Console.WriteLine($"Repetição DO... While nº: {x}");
                x--;
            } while (x > 0);
            /*-------------------------------------------------------*/



            Console.ReadLine();
        }
    }
}
