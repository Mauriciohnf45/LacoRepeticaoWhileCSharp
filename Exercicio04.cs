using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = int.Parse(Console.ReadLine()); 
            int contador = 1;

            Console.WriteLine($"Tabuada do {numero}:");

            
            while (contador <= 10)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
                contador++; 
            }

            Console.WriteLine("Tabuada concluída!");
            Console.ReadLine(); 
        }
    }
}

