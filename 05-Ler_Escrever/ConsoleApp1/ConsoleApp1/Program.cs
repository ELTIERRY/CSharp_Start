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
            Console.WriteLine("Testando texto na tela...");
            Console.Write("Digite seu nome: ");
            string _SeuNome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int _Idade = Convert.ToInt16(Console.ReadLine());
            // int _Idade = int.Parse(Console.ReadLine()); // Outra forma de converter String para inteiro


            // Abaixo três formas de imprimir a mesmo resultado
            Console.WriteLine("Olá {0}!, Bem vindo... Sua idade é: {1} ", _SeuNome, _Idade);
            Console.WriteLine($"Olá {_SeuNome}!, Bem vindo... Sua idade é: {_Idade} ");
            Console.WriteLine("Olá " + _SeuNome + "!, Bem vindo... Sua idade é: " + _Idade);

            Console.ReadLine();

        }
    }
}
