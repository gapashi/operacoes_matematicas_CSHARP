// Mini programinha de operações aritméticas em C#

Console.WriteLine("Este código foi desenvolvido por Gabriella Shibata como objetivo de estudo da linguagem de programação C#\n");
MensagemBoasVindas();

void MensagemBoasVindas()
{
    Console.WriteLine("Seja bem-vindo(a) ao sistema de Operações Matemáticas em C#!\n");
    Console.Write("Digite qualquer tecla para inciar: ");
    Console.ReadKey();

    Thread.Sleep(1000);
    OperacoesMatematicas();
}

void OpcaoMenus()
{
    Console.Write("Deseja voltar ao menu principal? (s/n): ");

    string opcao = Console.ReadLine()!;

    if (opcao == "s")
    {
        OperacoesMatematicas();
        Thread.Sleep(3000);
        Console.Clear();
    }
    else if (opcao == "n")
    {
        MensagemBoasVindas();
        Thread.Sleep(3000);
        Console.Clear();
    }
}

void OperacoesMatematicas()
{
    Console.WriteLine("Olá, jovem! Vamos fazer contas?");
    Console.WriteLine("Escolha uma das operações abaixo:\n");

    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAÇÃO");
    Console.WriteLine("3 - DIVISÃO");
    Console.WriteLine("4 - MULTIPLICAÇÃO");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int numero = int.Parse(opcaoEscolhida);

    switch(numero)
    {
        case 1: Soma();
            break;
        case 2: Subtracao();
            break;
        case 3: Divisao();
            break;
        case 4: Multiplicacao();
            break;
        default: Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}

void Soma()
{
    Console.Clear();
    Console.WriteLine("Você escolheu a função SOMA.\n");
    Console.Write("Digite o primeiro número que deseja somar: \n");

    string somaA = Console.ReadLine()!;
    int soma1 = int.Parse(somaA);

    Console.WriteLine("Digite o segundo número que deseja somar: \n");

    string somaB = Console.ReadLine()!;
    int soma2 = int.Parse(somaB);

    int soma = soma1 + soma2;

    Console.WriteLine($"A soma dos números informados é {soma}");

    OpcaoMenus();
}

void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Você escolheu a função SUBTRAÇÃO.\n");
    Console.Write("Digite o primeiro número que deseja subtrair: \n");

    string menosA = Console.ReadLine()!;
    int menos1 = int.Parse(menosA);

    Console.WriteLine("Digite o segundo número que deseja subtrair: \n");

    string menosB = Console.ReadLine()!;
    int menos2 = int.Parse(menosB);

    int subtracao = menos1 - menos2;

    Console.WriteLine($"A subtração dos números informados é {subtracao}");

    OpcaoMenus();
}

void Divisao()
{
    Console.Clear();
    Console.WriteLine("Você escolheu a função DIVISÃO.\n");
    Console.Write("Digite o primeiro número que deseja dividir: \n");

    string divA = Console.ReadLine()!;
    int div1 = int.Parse(divA);

    Console.WriteLine("Digite o segundo número que deseja subtrair: \n");

    string divB = Console.ReadLine()!;
    int div2 = int.Parse(divB);

    int divisao = div1 / div2;

    Console.WriteLine($"A subtração dos números informados é {divisao}\n");

    OpcaoMenus();
}

void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Você escolheu a função MULTIPLICAÇÃO.\n");
    Console.Write("Digite o primeiro número que deseja multiplicar: \n");

    string multiA = Console.ReadLine()!;
    int multi1 = int.Parse(multiA);

    Console.WriteLine("Digite o segundo número que deseja subtrair: \n");

    string multiB = Console.ReadLine()!;
    int multi2 = int.Parse(multiB);

    int multiplicacao = multi1 * multi2;

    Console.WriteLine($"A subtração dos números informados é {multiplicacao}\n");

    OpcaoMenus();
}