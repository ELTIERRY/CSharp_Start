using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=net-5.0
namespace ConsoleApp1
{
    class Program
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main(string[] args)
        {
            var Ndias = Enum.GetNames(typeof(DiasSemana)).Length;

            // Recuperando os nomes com o "FOR"
            for (int i = 0; i < Ndias; i++)
            {
                Console.WriteLine((DiasSemana)i);
            }
            Console.WriteLine("Tamanho do enum: {0}", Ndias);
            /*-------------------------------------------------------*/

            Console.WriteLine();

            // Outra forma com foreach
            foreach(int j in Enum.GetValues(typeof(DiasSemana))) // Poderia ser "GetNames" se utilizasse String "j"
            {
                Console.WriteLine((DiasSemana)j);
            }
            /*-------------------------------------------------------*/



            Console.ReadLine();
        }
    }
}
