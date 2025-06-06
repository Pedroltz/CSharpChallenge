# Documentação - Projeto de Desafios em C#

Projeto de desafios simples em C#, com menu interativo em console. Criado por Pedro Tunin como parte da Trilha Backend.

---

## Estrutura do Projeto

- `Program.cs`: Arquivo principal, exibe o menu e direciona para os desafios.
- `PlusPlus.cs`: Soma de 1 a 10.
- `Imc.cs`: Calculadora de IMC com classificação.
- `Calculator.cs`: Calculadora simples com operações básicas.

---

## ▶️ Program.cs

Exibe um menu com três desafios e executa a lógica com base na escolha do usuário.

### Menu de Opções:
1. Somar de 1 a 10 → `PlusPlus.AddNumbers()`
2. IMC Calculadora → `Imc.ImcCalculator()`
3. Calculadora Simples → `Calculator.SimpleCalc()`
0. Sair

---

## PlusPlus.cs

Desafio 1: Somar de 1 a 10

```csharp
for (int i = 0; i < 10; i++)
{
    soma++;
    Console.WriteLine(soma);
}
