using ChallengeProgram.Desafios;
using ConsoleApp1.Desafios;

int option = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine(@"
                ╔═══════════════════════════════════════════════════════╗
                ║                                                       ║
                ║       ████████╗██╗   ██╗███╗   ██╗██╗███╗   ██╗       ║
                ║       ╚══██╔══╝██║   ██║████╗  ██║██║████╗  ██║       ║
                ║          ██║   ██║   ██║██╔██╗ ██║██║██╔██╗ ██║       ║
                ║          ██║   ██║   ██║██║╚██╗██║██║██║╚██╗██║       ║
                ║          ██║   ╚██████╔╝██║ ╚████║██║██║ ╚████║       ║
                ║           ╚═╝    ╚═════╝ ╚═╝  ╚═══╝╚═╝╚═╝  ╚═══╝      ║
                ║                                                       ║
                ║         DESAFIO C# | TRILHA BACKEND - PEDRO TUNIN     ║
                ║                                                       ║
                ╚═══════════════════════════════════════════════════════╝
                ");

    Console.WriteLine("╔══════════════════════════════════════════════╗");
    Console.WriteLine("║                MENU DE OPÇÕES                ║");
    Console.WriteLine("╠══════════════════════════════════════════════╣");
    Console.WriteLine("║  1 - Desafio 1: Somar de 1 a 10              ║");
    Console.WriteLine("║  2 - Desafio 2: IMC Calculadora              ║");
    Console.WriteLine("║  3 - Desafio 3: Calculadora Simples          ║");
    Console.WriteLine("║  0 - Sair                                    ║");
    Console.WriteLine("╚══════════════════════════════════════════════╝");

    Console.Write("\nDigite sua escolha: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out option))
    {
        Console.Clear();
        switch (option)
        {
            case 1:
                PlusPlus.AddNumbers();
                break;
            case 2:
                Imc.ImcCalculator();
                break;
            case 3:
                Calculator.SimpleCalc();
                break;
            case 0:
                Console.WriteLine("Saindo...!");
                return;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Digite um número valido");
        Console.ReadKey();
    }
}
