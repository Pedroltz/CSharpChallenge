using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Desafios
{
    internal class PlusPlus
    {
        public static void AddNumbers()
        {   
            Console.Clear();
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma++;
                Console.WriteLine(soma);
            }
            Console.WriteLine("Digite 'ENTER' para continuar...");
            Console.ReadKey();
        }
    }
}
