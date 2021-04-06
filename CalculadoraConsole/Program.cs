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

            bool fazer_outra_operacao = false;

            do
            {
                Console.Clear();

                Console.WriteLine("   CALCULADORA DO CONSOLE    ");
                Console.WriteLine("Primeiro informe a operação e em seguida os números.");
                Console.WriteLine("Informe a operação:");
                Console.WriteLine("Digite + para Adição");
                Console.WriteLine("Digite - para Subtração");
                Console.WriteLine("Digite * para Multiplicação");
                Console.WriteLine("Digite / para Divisão");

                // looping....
                // Só deverá repetir se o usuário digitar
                // uma operação inválida.
                bool repetir_digitar_operacao = false;

                do
                {
                    operacao = Console.ReadLine();

                    switch (operacao)
                    {
                        case "+":
                            Console.Clear();
                            Console.WriteLine("Vamos somar!");
                        break;

                        case "-":
                        case "*":
                        case "/":
                            repetir_digitar_operacao = false;
                            break;
                        default:
                            repetir_digitar_operacao = true;
                            Console.WriteLine("Operação inválida. Digite novamente.");
                            break;
                    }

                } while (repetir_digitar_operacao);
                // Enquanto. Dentro dos parenteses é feito o teste de verdadeiro ou falso.
                // a variável repetir_digitar_operacao é booleana, ou seja, true ou false.
                // Esse código pode ser otimizado?

                //Console.Clear();

                /**
                 * "Tentando" ler o número que o usuário digitou.
                 * Vamos testar se o usuário digitou um número.
                 *
                 * Teste de como funciona o TryParse abaixo:
                 * 
                 * string entrada = Console.ReadLine();
                 * bool entrada_valida;
                 * entrada_valida = Double.TryParse(entrada, out n1);
                 * Console.WriteLine("Valor de entrada_valida é {0} ", entrada_valida);
                */

                bool entrada_valida_n1 = false;
                do
                {
                    Console.WriteLine("Informe o primeiro número:");
                    entrada_valida_n1 = Double.TryParse(Console.ReadLine(), out n1);

                } while (!entrada_valida_n1);


                bool entrada_valida_n2 = false;
                do
                {
                    Console.WriteLine("Informe o segundo número:");
                    entrada_valida_n2 = Double.TryParse(Console.ReadLine(), out n2);

                } while (!entrada_valida_n2);


                // Escolha
                switch (operacao)
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

                Console.WriteLine("Deseja fazer outra operação? S/n");

                /*if (Console.ReadLine().ToUpper() == "S")
                    fazer_outra_operacao = true;
                else
                    fazer_outra_operacao = false;*/


                // Fazendo com operdor ternário
                fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;

            } while (fazer_outra_operacao);

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



            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
    }
}
