while (true)
{
    Menu();
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Selecione a operação desejada: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Dividir");
    Console.WriteLine("4 - Multiplicar");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("--------------------");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Somar(); break;
        case 2: Subtrair(); break;
        case 3: Dividir(); break;
        case 4: Multiplicar(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Somar()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());
    float resultado = primeiroValor + segundoValor;

    Console.WriteLine();

    /* Console.WriteLine("Primeiro valor digitado: " + primeiroValor);
       Console.WriteLine("Segundo valor digitado: " + segundoValor);

       Console.WriteLine("Resultado da Soma é: " + (primeiroValor + segundoValor));
       Console.WriteLine("Resultado da Soma é: " + resultado);
       Console.WriteLine($"Resultado: {primeiroValor + segundoValor}"); 
    */
    Console.WriteLine($"Resultado da soma: {resultado}");
    Console.ReadKey();
}

static void Subtrair()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());
    float resultado = primeiroValor - segundoValor;

    Console.WriteLine();
    Console.WriteLine($"Resultado da subtração: {resultado}");
    Console.ReadKey();
}

static void Dividir()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());
    float resultado = primeiroValor / segundoValor;

    Console.WriteLine();
    Console.WriteLine($"Resultado da divisão: {resultado}");
    Console.ReadKey();
}

static void Multiplicar()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());
    float resultado = primeiroValor * segundoValor;

    Console.WriteLine();
    Console.WriteLine($"Resultado da multiplicação: {resultado}");
    Console.ReadKey();
}