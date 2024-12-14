using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            int numeroSecreto = 42;
            int palpite;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto.");

            do
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine()); 

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }

            } while (palpite != numeroSecreto); 

            Console.WriteLine("Parabéns! Você acertou o número secreto!");
            Console.ReadLine(); 
        }
    }
}
