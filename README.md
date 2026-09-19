# Calculadora Semi-Científica (C# / Windows Forms)

Projeto acadêmico desenvolvido em **C#** utilizando **Windows Forms**, no
**Visual Studio 2022**, implementando uma calculadora básica "semi-científica".

## Como abrir no Visual Studio 2022

1. Abra o Visual Studio 2022.
2. Clique em **Abrir uma pasta** (ou **Open a local folder**) e selecione a
   pasta `CalculadoraSemiCientifica` extraída do .zip.
3. O Visual Studio vai reconhecer automaticamente o arquivo
   `CalculadoraSemiCientifica.csproj`. Dê duplo clique nele se necessário.
4. Pressione **F5** (ou clique em "Iniciar") para compilar e executar.

> O projeto usa o modelo **SDK-style** (.NET 8, Windows Forms). Caso seu
> Visual Studio não tenha o *workload* "Desenvolvimento para desktop com .NET"
> instalado, instale-o pelo Visual Studio Installer.

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

## Antes de entregar o trabalho, personalize:

1. Abra `FrmSobre.Designer.cs` e substitua:
   - O texto de `txtIntegrantes.Text` pelos nomes reais dos integrantes do
     grupo (e RA/matrícula, se solicitado pelo professor).
   - O texto de `lnkGithub.Text` pelo link real do repositório do grupo no
     GitHub.
   - Se quiser, ajuste também o texto de `txtResumo.Text` com o resumo que o
     grupo preferir.
2. Opcional: altere cores/fontes em `FrmCalculadora.Designer.cs` para
   personalizar ainda mais o layout.

## Observação sobre o separador decimal

Para simplificar a lógica e evitar problemas de conversão, a calculadora usa
o **ponto (`.`)** como separador decimal (padrão internacional /
`CultureInfo.InvariantCulture`), independentemente da configuração regional
do Windows.
