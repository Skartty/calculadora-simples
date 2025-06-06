# calculadora-simples
Calculadora com funções simples - Projeto IFSP 2Sem

## Como funciona o código

Este projeto é uma calculadora simples desenvolvida em C# utilizando Windows Forms (.NET Framework 4.8). O código principal está no arquivo `Form1.cs`, que implementa a interface gráfica e a lógica das operações matemáticas básicas.

### Tecnologias utilizadas

- **C# 7.3**: Linguagem de programação utilizada para toda a lógica da aplicação.
- **.NET Framework 4.8**: Plataforma de execução da aplicação desktop.
- **Windows Forms**: Biblioteca gráfica para construção da interface do usuário.

### Estrutura e funcionamento

- **Interface gráfica**:  
  A interface é composta por botões numéricos (0-9), botões de operações (+, -, *, /), botão de igual (=), vírgula (,) e limpar (C). Os campos `BoxResultado` e `txtOperacao` exibem o número digitado e a operação em andamento, respectivamente.

- **Lógica das operações**:  
  A classe `Operacoes` contém métodos para cada operação matemática:
    - `Soma(double x, double y)`
    - `Subtracao(double x, double y)`
    - `Mult(double x, double y)`
    - `Divisao(double x, double y)`

- **Fluxo de uso**:
    1. O usuário digita números usando os botões.
    2. Ao clicar em uma operação (+, -, *, /), o valor atual é armazenado e a operação é exibida.
    3. O usuário digita o segundo número e pressiona o botão de igual (=).
    4. O resultado é calculado pelo método correspondente da classe `Operacoes` e exibido.
    5. O botão C limpa todos os campos e reseta o estado da calculadora.

- **Tratamento de erros**:  
  O código impede divisão por zero, exibindo uma mensagem de erro caso isso ocorra.

### Exemplo de uso

1. Digite um número.
2. Clique em uma operação (por exemplo, +).
3. Digite outro número.
4. Clique em = para ver o resultado.
5. Use o botão C para limpar e começar uma nova operação.

---

**Referências:**
- [Documentação C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Documentação .NET Framework](https://docs.microsoft.com/pt-br/dotnet/framework/)
- [Documentação Windows Forms](https://docs.microsoft.com/pt-br/dotnet/desktop/winforms/)