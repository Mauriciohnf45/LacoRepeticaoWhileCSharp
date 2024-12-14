using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int resultado = numero;
            int potencia = 1;

            Console.WriteLine($"Sequência de multiplicação de {numero} por potências de 2:");

            
            while (resultado <= 1000)
            {
                Console.WriteLine($"{numero} * {potencia} = {resultado}");
                potencia *= 2;
                resultado = numero * potencia;
            }

            Console.WriteLine("O resultado ultrapassou 1000.");
            Console.ReadLine();
        }
    }
}

