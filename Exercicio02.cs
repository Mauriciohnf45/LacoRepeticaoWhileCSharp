using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            int numero; 
            int soma = 0; 

            Console.WriteLine("Digite números inteiros para somar. Digite 0 para encerrar.");

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine()); 
                soma += numero; 
            } while (numero != 0); 

            Console.WriteLine($"A soma dos números digitados é: {soma}");
            Console.ReadLine(); 
        }
    }
}

