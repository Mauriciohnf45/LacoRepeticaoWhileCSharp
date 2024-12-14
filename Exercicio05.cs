using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine()); // Lê o número do usuário

                if (numero % 2 != 0)
                {
                    Console.WriteLine("O número é ímpar. Tente novamente.");
                }

            } while (numero % 2 != 0); // Continua enquanto o número for ímpar

            Console.WriteLine("Parabéns! Você digitou um número par.");
            Console.ReadLine(); // Mantém o console aberto
        }
    }
}

