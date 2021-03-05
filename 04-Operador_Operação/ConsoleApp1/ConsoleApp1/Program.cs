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
            float a = 10;
            float b = 3;

            float res_soma = a + b; // soma: 13
            float res_subt = a - b; //subtração: 7
            float res_mult = a * b; // multiplicação: 30
            float res_div = a / b; // divisão: 3,333333
            float res_rest = a % b; // rest divisão: 1
            bool res1_bool = a > b; // Comparação: true
            bool res2_bool = a >= b; // Comparação: true
            bool res3_bool = a < b; // Comparação: false
            bool res4_bool = a <= b; // Comparação: false
            bool res5_bool = a == b; // Comparação igualdade: false     
            bool res6_bool = a != b; // Comparação diferente: True
            bool res7_bool = (a > b) || (b != a); // Operação OR: Resultado true
            bool res8_bool = (a > b) && (b == a); // Comparação AND: Resultado false

            // Formas de incrementos. Pode ser usado com + - * /
            int x = 20;
            x++; //Soma a variável x + 1. Resultado: 21
            x += 1; //Soma a variável x + 1. Resultado: 22
            x += 2; //Soma a variável x + 2. Resultado: 24

            /*------------------Operadores Lógicos AND: &, OR: |, XOR: ^--------------------------*/
            int d1 = 6, d2 = 3;
            int v1 = (d1 | d2); // Operação OR: 0110 OR 0011. Resultado 7. 
            int v2 = (d1 & d2); // Comparação AND: 0110 OR 0011. Resultado 2
            Console.WriteLine(v1);
            /*---------------------------------------------------------------------------------*/


            /*----------------Operação BITWISE << >>-------------------------------------------*/
            
            int n1 = 3;
            n1 = n1 << 1; // Desloca o número 3 (0011xb) uma vez a esquerda. Resultado 6 (0110xb)

            int n2 = 10;
            n2 = n2 >> 1; // Desloca o número 10 (1010xb) uma vez a esquerda. Resultado 5 (0101xb)

            /*------------------------------------------------------------------------------------*/


            Console.ReadLine();    
        }
    }
}
