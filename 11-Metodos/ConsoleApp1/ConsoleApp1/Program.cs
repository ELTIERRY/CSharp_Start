using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            int A = 1, B = 2, C = 3, D = 4, E = 5, F = 6;
            float V1 = 150f, V2 = 400f, V3 = 900f, rV2 = 0f, rV3 = 0;

            Soma(A, B); // Envia valores de A e B para o método Soma() e lá executa a operação.

            /* Envia valores de C e D para o método Mult() e retorna com o resultado para "Res1" */
            int Res1 = Mult(C, D); 
            Console.WriteLine("Multiplicação de C e D: {0} ", Res1);
            /*------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------
            Envia V1 = 150 para o método Metade(). 
            Usando "ref" a operação será feita diretamente na variável V1, ou seja, 
            lá dividirá por 2 resultando 75. Isso chama-se passagem por referência.-------*/
            Metade(ref V1);
            Console.WriteLine("Novo valor de V1: {0}", V1);
            /*--------------------------------------------------------------------------*/

            /*-------------------------------------------------------------------------------
            Chama método "Raiz" que envia dois valores e retorna dois valores usando o argumento "out"---*/
            Raiz(V2, V3, out rV2, out rV3);
            Console.WriteLine($"Raiz de {V2} é {rV2} e {V3} é {rV3}");
            /*---------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------
            Cria um array misto usando "object" e envia para o método Dados1-----------*/
            object[] myObjArray = { 2, 'b', "teste", "1000" };
            Dados1(myObjArray); // Poderia enviar sem criar o array. Ex: Dados1(2, 'b', "teste", "1000")
            /*--------------------------------------------------------------------------*/

            MsgFinal(); /* Chama o método MsgFinal() */

            Console.ReadLine();
        }

        static void Soma(int X, int Y) // Método que recebe valores mas sem retorno de valor (Void).
        {
            Console.WriteLine($"Soma de A e B: {X + Y}"); // X recebe A=1 e Y recebe B=2
        }

        static int Mult(int U, int V) // Método que receebe valores e com retorno de valor para o "Mult"
        {
            int W = U * V; // U recebe C = 3 e V recebe D = 4
            return W;
        }

        static void Metade(ref float V10) // Método que recebe valor mas sem retorno de valor (Void)
        {
            V10 /= 2; //Divide V10 por 2. 150 / 2 = 75
        }

        static void Raiz(float T1, float T2, out float T3, out float T4) // Método que receebe dois valores e retorna dois valores (out) para o "Main"
        {
            // Foi usado o cast (float) pois Math.Sqrt retorna double
            T3 = (float)Math.Sqrt(T1);
            T4 = (float)Math.Sqrt(T2);
        }

        static void Dados1(params object[] lista) // Método que recebe um array usando o argumento "params"
        {
            Console.Write("Ítens da lista: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }

        static void MsgFinal() // Método que nem recebe e nem retorna valor
        {
            Console.WriteLine("Até Logo......");
        }



    }
}
