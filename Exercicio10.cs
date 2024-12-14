using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine()); 

           
            numero = Math.Abs(numero); 

            int contador = 0;

            
            if (numero == 0)
            {
                contador = 1;
            }
            else
            {
                
                while (numero > 0)
                {
                    numero /= 10; 
                    contador++;   
                }
            }

            Console.WriteLine($"O número possui {contador} dígitos.");
            Console.ReadLine(); 
        }
    }
}

