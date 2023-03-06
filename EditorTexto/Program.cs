Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer? ");
    Console.WriteLine();
    Console.WriteLine("1 - Abrir arquivo de texto");
    Console.WriteLine("2 - Criar arquivo de texto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("------------------------------");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: AbrirArquivo(); break;
        case 2: CriarArquivo(); break;
    }

}

static void AbrirArquivo()
{
    Console.Clear();
    Console.WriteLine("Qual é o caminho do arquivo?");
    var caminho = Console.ReadLine();

    using (var arquivo = new StreamReader(caminho))
    {
        string texto = arquivo.ReadToEnd();
        Console.WriteLine(texto);
    }
    Console.WriteLine();
    Console.ReadLine();
    Menu();
}

static void CriarArquivo()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
    Console.WriteLine("-------------------------");

    string texto = "";

    // Digita texto, enquanto usuário não digitar ESC (escape)  
    do
    {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(texto);
}

static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para salvar o arquivo? ");
    var caminho = Console.ReadLine();

    // o using faz a abertura e fechamento da origem passada por parâmetro, no caso vai ser um arquivo txt
    //   mas pode ser também BD
    using(var arquivo = new StreamWriter(caminho))
    {
        // stream = fluxo, writer = escritor | essa classe cria um objeto que para registrar em arquivo
        //                                      um fluxo de bytes
        arquivo.Write(texto);
    }

    Menu();
}