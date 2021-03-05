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
            int n1 = 10;
            Double n2 = Convert.ToDouble(n1); //Convertendo o inteiro n1 em Double

            String _texto1 = "5";
            Double n3 = Double.Parse(_texto1); // Convertendo String para Double pelo método "Parse"

            String _texto2 = "57";
            Double n4 = Convert.ToInt16(_texto2); // Convertendo String para Int pelo método "Convert.To xxx"

            int n5 = 234;
            String _texto3 = Convert.ToString(n5); //Convertendo o inteiro n1 em String

            Double n6 = 522.67;
            int n7 = (int)n6;   // Convertendo Double em Int usando "typecast" (conversão perigosa)





            Console.ReadKey();
        }
    }
}
