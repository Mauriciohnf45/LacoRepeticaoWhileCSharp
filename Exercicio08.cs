using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            string entrada;

            Console.WriteLine("Contador de Vogais!");
            Console.WriteLine("Digite uma frase ou palavra (ou 'fim' para encerrar):");

            do
            {
                Console.Write("Digite sua entrada: ");
                entrada = Console.ReadLine()?.ToLower();

                if (entrada == "fim")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                int contadorVogais = 0;

                
                foreach (char c in entrada)
                {
                    if ("aeiou".Contains(c))
                    {
                        contadorVogais++;
                    }
                }

                Console.WriteLine($"Número de vogais na entrada: {contadorVogais}");

            } while (entrada != "fim");

            Console.ReadLine();
        }
    }
}
