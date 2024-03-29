### Comandos Git 

    // Enviar alterações para o repositório no github
    1- git add . // Pegando todas as alterações
    2- git commit -m "sua mensagem" // Mensagem que aparecerá no github
    3- git push // empurrando as alterações para o github

    // puxando alterações do github para sua maquina local
    git pull

### cli dotnet

    Criar aplicação de console: dotnet new console // Por enquanto apenas este
    Criar aplicação de tests: dotnet new xunit
    Criar aplicação de WebApi: dotnet new WebApi

### Atalhos do teclado

    shift + end // seleciona a linha até o final
    shift + home // seleciona a linha até o inicio
    ctrl + shift + setas // selecionando palavras
    ctrl + space // Aparecer na tela as opções que podem ser digitadas
    ctrl + . // importar algo

### Escrevendo e lendo do console
    // Escrever
    Console.WriteLine("Qual é a sua idade?");
    
    // Ler e salvar o resultado
    var result = Console.ReadLine();

    // Juntar textos
    string text = $"Olá, {result}";

### Declarando variáveis e constantes
    var text = "meu texto"
    string text = "meu texto"
    const string text = "meu texto"

### Tipos de variáveis
    // Tipo numérico/int
    var number = 1

    // Tipo texto/string
    var text = "meu texto"
    
    // Tipo booleano/bool
    var boolean = true ou false

    // Tipo numérico com ponto flutuante/double
    var price = 4.099

    // Tipo Data/DateTime
    var currentDate = DateTime.Now;

    // Tipo Nullable Double
    double? x = null;

    // Lista/Array de 1 posição
    var names = new string[1];
    names[0] = "Lucas";
    // names terá o valor Lucas na posição de número 0

    // Tupla / Tuple
    (string name, int votes) firstCandidate = ("", 0)

    //tuple/array
    var candidates = new (string name, int votes)[3];

### Parsers / Transformadores
    // Transformar um texto/string em um número/int
    var userAge = Int32.Parse(result);

    // Transformar um texto/string em um número com ponto flutuante/double
    double price = Double.Parse(result);

    // Formatar número/double para até duas casas decimais após a vírgula
    25.658499.ToString("0.00")
    // 25.66

### Operadores de comparação
#### (toda comparação retorna um booleano/bool)
    // É igual?
    1 == 1;
    // vai retornar true

    // É diferente?
    1 != 1;
    // vai retornar false
    
    // É diferente?
    !(1 == 1);
    // vai retornar false

    // Booleano da esquerda é true e o da direita também?
    true && true && false;
    // vai retornar false

    // Booleano da esquerda ou o da direita é true?
    false || false || true;
    // vai retornar true

    // Operador ternário
    var myBool = true;
    var message = myBool ? "Solteiro" : "Não solteiro";
    // retornará "Solteiro" quando myBool for True ou "Não solteiro quando for False

### Operadores de comparação para números/matemática
    // É maior?
    1 > 1;
    // vai retornar false

    // É menor?
    1 < 1;
    // vai retornar false
    
    // É maior OU igual?
    1 >= 1;
    // vai retornar true
    
    // É menor OU igual?
    1 <= 1;
    // vai retornar true

### Operadores de matemática
    // Somar
    1 + 1;

    // Subtrair
    1 - 1;
    
    // Dividir
    2 / 1;
    
    // Multiplicar
    1 * 2;

    // Resto
    3 % 2;
    // vai retornar 1
    
    // Incrementando uma variável (2 vezes)
    var counter = 0;
    var counter++;
    var counter += 1;
    // counter terá o valor 2

    // Decrementando uma variável
    var counter = 10;
    var counter--;
    // counter terá o valor 9

### Blocos condicionais
    // Escrevendo olá SOMENTE quando 1 > 0
    if (1 > 0)
    {
       Console.WriteLine("Olá")
    }
    // Caso 1 NÃO for maior que 0, e 2 > 1, escreva Boa tarde!
    else if (2 > 1)
    {
       Console.WriteLine("Boa tarde!")
    }
    // Caso NENHUMA das condições anteriores forem verdadeiras, escreva Xau!
    else
    {
       Console.WriteLine("Xau!")
    }

### Laços de repetição
    // while
    while (true)
    {
        Console.WriteLine("Olá!");
    }
    // Dirá olá infinitamente

    // forçando para que um laço de repetição pare
    while (true)
    {
        break;
    }

    // continuando o looping pulando o restante do código
    while (true)
    {
        continue;

        ....
    }

    // for (imprimindo de 0 a 9)
    for (int counter = 0; counter < 10; counter++)
    {
        System.Console.WriteLine(counter);
    }

    // foreach (imprimindo todos os elementos do array "numbers")
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }

### Capturando exceções
    Console.WriteLine("Forneça um número");
    string firstInput = Console.ReadLine();
    
    try
    {
        var firstNumber = Int32.Parse(firstInput);
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("O números está em formato inválido");
    }

### Métodos
    // Retornando de um método:
    return;

### Comandos do editor
Selecionando o texto:
Segurar a tecla shift e utilizar as setas

Comando para mover código entre linhas
Selecione as linhas desejada e segure a tecla ALT + setinha deseja

Comando para comentar:
CTRL + K + C

Comando para descomentar:
CTRL + K + U

Comando para desfazer:
CTRL + Z

Comando para abrir arquivo especifico:
CTRL + p

Comando para refazer:
CTRL + Y

Comando para abrir o terminal:
CTRL + "

### Depurando a aplicação

1. Clicar na baratinha e depois no botao de engrenagem;
2. Selecionar o texto '.Net Core'
3. Alterar a opção "console" para "integratedTerminal"
4. Adicionar quantos breakpoints quiser (clicar na esquerda do número da linha)
5. Clicar na baratinha e no botão Start (verdinho)
6. Selecionar o Terminal (Sair na tab "Debug Console")
7. F10 vai para a próxima linha
8. F5 para o próximo breakpoint
9. Shift + F5 para "matar" a aplicação
10. CTRL + Shift + F5 para reiniciar o debug