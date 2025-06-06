using System;
using System.Globalization;

namespace ChallengeProgram.Desafios
{
    internal class Calculator
    {
        public static void SimpleCalc()
        {
            Console.Clear();

            double numero1;
            while (true)
            {
                Console.Write("Digite o primeiro número: ");
                try
                {
                    string entrada = Console.ReadLine()?.Replace(",", ".");
                    numero1 = Convert.ToDouble(entrada, CultureInfo.InvariantCulture);
                    break;
                }
                catch
                {
                    Console.WriteLine("Valor inválido! Digite um número válido.\n");
                }
            }

            double numero2;
            while (true)
            {
                Console.Write("Digite o segundo número: ");
                try
                {
                    string entrada = Console.ReadLine()?.Replace(",", ".");
                    numero2 = Convert.ToDouble(entrada, CultureInfo.InvariantCulture);
                    break;
                }
                catch
                {
                    Console.WriteLine("Valor inválido! Digite um número válido.");
                }
            }

            string operacao;
            while (true)
            {
                Console.Write("Escolha a operação (+, -, *, /): ");
                operacao = Console.ReadLine();
                try
                {
                    if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
                        throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("Operação inválida! Tente novamente.");
                }
            }

            Console.Clear();

            double resultado = 0;
            bool operacaoValida = true;

            try
            {
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
                        if (numero2 == 0)
                            throw new DivideByZeroException();
                        resultado = numero1 / numero2;
                        break;
                }

                Console.WriteLine($"Resultado: {resultado:F2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero!");
                operacaoValida = false;
            }

            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
