using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Uma calculadora que dê instruções iniciais ao usuário.
             * A primeira instrução, o usuário deverá entrar com a operação
             * (+ - + /) e em seguida com o primeiro número e na sequencia o
             * segundo número.
             */

            string operacao;
            double n1;
            double n2;
            double resultado = 0;

            Console.WriteLine("   CALCULADORA DO CONSOLE    ");
            Console.WriteLine("Primeiro informe a operação e em seguida os números.");
            Console.WriteLine("Informe a operação:");
            Console.WriteLine("Digite + para Adição");
            Console.WriteLine("Digite - para Subtração");
            Console.WriteLine("Digite * para Multiplicação");
            Console.WriteLine("Digite / para Divisão");

            operacao = Console.ReadLine();

            Console.WriteLine("Informe o primeiro número:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            n2 = Convert.ToDouble(Console.ReadLine());

            // Escolha
            switch(operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    Console.WriteLine("O resultado da adição é {0} ", resultado);
                    break;

                case "-":
                    resultado = n1 - n2;
                    Console.WriteLine("O resultado da subtração é {0} ", resultado);
                    break;

                case "*":
                    resultado = n1 * n2;
                    Console.WriteLine("O resultado da multiplicação é {0} ", resultado);
                    break;

                case "/":
                    resultado = n1 / n2;
                    Console.WriteLine("O resultado da divisão é {0} ", resultado);
                    break;

                default:
                    Console.WriteLine("opção inválida. Informado {0} ", operacao);
                    break;
            }

            /*if (operacao == "+")
            {
                resultado = n1 + n2;

            } else if(operacao == "-")
            {
                resultado = n1 - n2;

            } else if(operacao == "*")
            {
                resultado = n1 * n2;

            } else if(operacao == "/")
            {
                resultado = n1 / n2;
            }*/

           


            Console.ReadKey();
        }
    }
}
