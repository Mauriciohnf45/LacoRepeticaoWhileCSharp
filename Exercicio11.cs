using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            int numero;
            int tentativas = 0;

            Console.WriteLine("Digite um número entre 1 e 100.");

           
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine()); 
                tentativas++; 

                if (numero < 1 || numero > 100) 
                {
                    Console.WriteLine("Número inválido! O número deve estar entre 1 e 100. Tente novamente.");
                }

            } while (numero < 1 || numero > 100);

            Console.WriteLine($"Você digitou um número válido ({numero}) após {tentativas} tentativas.");
            Console.ReadLine(); 
        }
    }
}

