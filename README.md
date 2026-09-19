# Calculadora Semi-Científica (C# / Windows Forms)

Projeto acadêmico desenvolvido em **C#** utilizando **Windows Forms**, no
**Visual Studio 2022**, implementando uma calculadora básica "semi-científica".

## Estrutura do projeto

| Arquivo | Responsabilidade |
|---|---|
| `Program.cs` | Ponto de entrada da aplicação (`Main`). |
| `Calculadora.cs` | Classe `CalculadoraEngine` — contém **toda a lógica matemática** (soma, subtração, multiplicação, divisão, raiz quadrada, potenciação e controle da memória M), separada da interface. |
| `FrmCalculadora.cs` / `FrmCalculadora.Designer.cs` | Formulário principal (a calculadora em si): botões, visor e tratamento dos cliques. |
| `FrmSobre.cs` / `FrmSobre.Designer.cs` | Segunda tela (Forms), acessível pelo menu **Ajuda > Sobre**, com os integrantes do grupo, resumo do trabalho e link do GitHub. |

## Funcionalidades implementadas

- Botões numéricos de **0 a 9** e botão de ponto decimal (`.`).
- Visor (`TextBox`) somente leitura, com o texto alinhado à **direita**.
- Quatro operações aritméticas básicas: **+, -, x, /**.
- Botão **√y** (raiz quadrada) e **x^y** (potenciação).
- Botão **=** para calcular e exibir o resultado.
- Botão **C** para limpar o visor e reiniciar a conta.
- Memória (**M**): botões **M+** (soma o valor do visor à memória), **MR**
  (recupera o valor da memória) e **MC** (zera a memória), com um pequeno
  indicador "M" que aparece quando há valor armazenado.
- Tratamento de erros (ex.: divisão por zero e raiz de número negativo)
  exibindo uma mensagem (`MessageBox`) ao usuário.
- Tela **Sobre** (segundo Form) com os integrantes do grupo, resumo do
  trabalho e link para o GitHub.
