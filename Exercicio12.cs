using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            int numero;
            int contagemPares = 0;
            int contagemImpares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");

            
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine()); 

                if (numero == 0)
                {
                    break; 
                }

                
                if (numero % 2 == 0)
                {
                    contagemPares++;
                }
                else
                {
                    contagemImpares++;
                }

            } while (numero != 0); 

            
            Console.WriteLine($"Total de números pares: {contagemPares}");
            Console.WriteLine($"Total de números ímpares: {contagemImpares}");
            Console.ReadLine(); 
        }
    }
}
