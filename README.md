
# 📘 Documentação - Projeto de Desafios em C#

Projeto de desafios simples em C#, com menu interativo em console. Criado por Pedro Tunin como parte da Trilha Backend.

---

## 📂 Estrutura do Projeto

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

## ➕ PlusPlus.cs

Desafio 1: Somar de 1 a 10

```csharp
for (int i = 0; i < 10; i++)
{
    soma++;
    Console.WriteLine(soma);
}
```

Simples incremento com exibição da sequência até 10.

---

## ⚖️ Imc.cs

Desafio 2: Calculadora de IMC

### Lógica:
1. Usuário digita peso e altura.
2. Valores são convertidos com validação via `try-catch`.
3. Cálculo: `IMC = peso / (altura * altura)`
4. Exibe classificação com base no valor:

| Faixa de IMC         | Classificação           |
|----------------------|-------------------------|
| Abaixo de 18.5       | Abaixo do peso          |
| 18.5 a 24.9          | Peso normal             |
| 25.0 a 29.9          | Sobrepeso               |
| 30.0 a 34.9          | Obesidade grau 1        |
| 35.0 a 39.9          | Obesidade grau 2        |
| 40.0 ou mais         | Obesidade grau 3        |

---

## ➗ Calculator.cs

Desafio 3: Calculadora simples

### Funcionalidades:
- Operações: `+`, `-`, `*`, `/`
- Validação de entrada numérica e operação
- Tratamento de erro de divisão por zero

### Exemplo de fluxo:

```csharp
switch (operacao)
{
    case "+": resultado = numero1 + numero2; break;
    case "/": 
        if (numero2 == 0) throw new DivideByZeroException();
        resultado = numero1 / numero2; 
        break;
}
```

---

## ✅ Considerações

- Projeto usa `try-catch` para validação de entrada do usuário.
- Códigos focados em prática com estrutura básica.
- Ótimo para estudos iniciais de C# com console.

---
