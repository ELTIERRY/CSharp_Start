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
            //Criando um array tipo int "posic" tamanho 5 e atribuindo os valores posteriormente para cada índice
            int[] posic = new int[5];
            posic[0] = 5;
            posic[1] = 26;
            posic[2] = 100;
            posic[3] = 2;
            posic[4] = 13;

            //Criando array tipo int "num" tamanho 3 e de outra forma atribuindo valores
            int[] num = new int[3] {89, 24, 52};


            /*Criando array  tipo int "seq". O Tamanho será definido pela quantidade de elementos dentro das chaves { }.
             No exemplo abaixo o tamanho será quatro */
            int[] seq = {24, 16, 80, 27};


            /* Cria um array tipo object chamado "lista" que pode receber valores mistos: int, string, float.... */
            object[] lista = { 24, "teste", "80", "32.7", 9.63 };


            /* ---------------------------- Matrizes (Arrays bidimensionais) -----------------------------------*/

            int[ , ] n = new int[2, 3]; // Matriz com duas linhas e três colunas 2x3

      
            n[0, 0] = 5;  n[0, 1] = 12; n[0, 2] = 25;
            n[1, 0] = 13; n[1, 1] = 87; n[1, 2] = 94;

            /*Resultado
             5  12  25
            13  87  94
             */

            /*-------------------------------------------------------------------------------*/


            //Definindo tamanho da matriz pela quantidade de elementos. Resultado igual acima.
            //                             1ª linha       2º linha
            int[ , ] nx = new int[2, 3] { { 5, 12, 25 }, { 13, 87, 94 } };


            Console.ReadLine();
        }
    }
}
