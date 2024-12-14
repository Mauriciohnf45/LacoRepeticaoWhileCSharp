using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio01
    {
       public static void Main(string[] args)
        {
            int numero = 1;

            
            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }

            Console.WriteLine("Contagem concluída!");
            Console.ReadLine();
        }
    }
}

