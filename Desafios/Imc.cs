using System;
using System.Globalization;

namespace ChallengeProgram.Desafios
{
    internal class Imc
    {
        public static void ImcCalculator()
        {
            Console.Clear();

            double peso;
            while (true)
            {
                Console.Write("Digite seu peso (em kg): ");
                try
                {
                    peso = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (peso <= 0)
                    {
                        Console.WriteLine("Peso deve ser maior que zero!");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido! Digite um número válido.");
                }
            }

            double altura;
            while (true)
            {
                Console.Write("Digite sua altura (em metros): ");
                try
                {
                    altura = Convert.ToDouble(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
                    if (altura <= 0)
                    {
                        Console.WriteLine("Altura deve ser maior que zero!");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido! Digite um número válido.");
                }
            }

            Console.Clear();

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Classificação: Obesidade grau 1");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("Classificação: Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade grau 3");
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
