using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se é primo: ");
            int numero = int.Parse(Console.ReadLine()); 

            if (numero <= 1)
            {
                Console.WriteLine("O número deve ser maior que 1 para ser considerado primo.");
            }
            else
            {
                int divisor = 2;
                bool ehPrimo = true;

                while (divisor <= Math.Sqrt(numero))
                {
                    if (numero % divisor == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                    divisor++;
                }

                if (ehPrimo)
                {
                    Console.WriteLine($"{numero} é um número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um número primo.");
                }
            }

            Console.ReadLine();
        }
    }
}
