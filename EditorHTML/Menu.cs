namespace EditorHTML
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTela();
            EscreverOpcoes();

            var opcao = short.Parse(Console.ReadLine());
            ManipularOpcaoMenu(opcao);
        }
        public static void EscreverOpcoes()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Escolha uma opção: abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }
        public static void DesenharTela()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        public static void ManipularOpcaoMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Mostrar(); break;
                case 2: Console.WriteLine(); break;
                case 0: Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                default: Exibir(); break;
            }
        }
    }
}