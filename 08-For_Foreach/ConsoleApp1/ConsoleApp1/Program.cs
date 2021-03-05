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
            /*--------------------Estrtura repetição FOR -------------------*/
            Console.Write("Digite o número de repetições... ");
            int repet = int.Parse(Console.ReadLine());

            for(int i = 0; i < repet; i++) 
            {
                Console.WriteLine($"Repetição nº {i + 1}");
            }
            /*--------------------------------------------------------------*/


            Console.WriteLine();


            /*--------------------Estrtura repetição FOREACH -------------------*/
            string[] animal = { "cobra", "macaco", "coelho", "elefante", "tigre", "águia" };

            int j = 1;
            foreach (string cont in animal)
            {
                Console.WriteLine($"Animal {j}: {cont}");
                j++;             
            }
            /*--------------------------------------------------------------*/


            Console.ReadLine();
        }
    }
}
