using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            string operacao;

            Console.WriteLine("Bem-vindo à Calculadora Simples!");
            Console.WriteLine("Escolha uma operação (+, -, *, /) ou digite 'sair' para encerrar.");

            do
            {
                Console.Write("\nDigite a operação desejada: ");
                operacao = Console.ReadLine()?.ToLower();

                if (operacao == "sair")
                {
                    Console.WriteLine("Encerrando a calculadora. Até mais!");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;
                bool operacaoValida = true;

                switch (operacao)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            operacaoValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida. Tente novamente.");
                        operacaoValida = false;
                        break;
                }

                if (operacaoValida)
                {
                    Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}");
                }

            } while (operacao != "sair");

            Console.ReadLine();
        }
    }
}

