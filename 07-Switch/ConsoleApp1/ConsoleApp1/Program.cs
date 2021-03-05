using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número... ");
            int N1 = int.Parse(Console.ReadLine());

            switch (N1)
            {
                case 1:
                    Console.WriteLine("Você digitou o número 1");
                    break;
                case 2:
                    Console.WriteLine("Você digitou o número 2");
                    break;
                case 3:
                    Console.WriteLine("Você digitou o número 3");
                    break;
                default:
                    Console.WriteLine("Você digitou o número diferente de 1, 2 e 3");
                    break;
            }

            Console.ReadLine();
        }
    }
}
