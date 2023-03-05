Menu();

static void IniciarCronometro(int tempo)
{
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear();
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        //Usar metodo Sleep da classe Thread para fazer com que seja esperado
        //    1 segundo (1000 milissegundos) antes de prosseguir com o while
        Thread.Sleep(1000);
    }

    Console.WriteLine("\nCronômetro finalizado.");
    Thread.Sleep(1000);

    Menu();
}

static void PreIniciar(int tempo)
{
    Console.Clear();
    Console.WriteLine("Iniciando em: 3...");
    Thread.Sleep(1000);
    Console.WriteLine("2...");
    Thread.Sleep(1000);
    Console.WriteLine("1...");
    Thread.Sleep(1000);
    IniciarCronometro(tempo);
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine(" S- Segundos.");
    Console.WriteLine(" M - Minutos.");
    Console.WriteLine(" 0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    // pega uma substring desde a posição correspondente à 
    //   largura-1 (que é a ultima posição do array de char que compõe a string), 
    //    contendo 1 caracter de largura.
    char tipo = char.Parse(data.Substring(data.Length - 1, 1));
    /* pega uma substring desde a posição 0 
        até o penúltimo caracter da string */
    int tempo = int.Parse(data.Substring(0, data.Length - 1));
    int multiplicador = 1;

    if (tipo == 'm')
    {
        multiplicador = 60;
    }

    if (tempo == 0)
    {
        System.Environment.Exit(0);
    }

    PreIniciar(tempo * multiplicador);
}