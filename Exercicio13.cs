using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            int numero;
            int somaPares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine()); 

                if (numero != 0 && numero % 2 == 0) 
                {
                    somaPares += numero; 
                }

            } while (numero != 0);

            
            Console.WriteLine($"A soma dos números pares digitados é: {somaPares}");
            Console.ReadLine();
        }
    }
}

