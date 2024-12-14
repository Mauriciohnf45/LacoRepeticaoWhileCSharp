using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            int numero = 10;

            Console.WriteLine("Contagem regressiva:");

            
            while (numero >= 1)
            {
                Console.WriteLine(numero);
                numero--;
            }

            Console.WriteLine("FIM!");
            Console.ReadLine(); 
        }
    }
}
