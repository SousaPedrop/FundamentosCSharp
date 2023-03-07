using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Visualizador
    {
        public static void Mostrar(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------------");
            Substituir(texto);
            Console.WriteLine("\n------------------");
            Console.ReadKey();

            Menu.Exibir();
        }

        public static void Substituir(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            
            var palavras = texto.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(palavras[i].Substring(
                        palavras[i].IndexOf('>') + 1,
                        ((palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>'))
                    ));
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
            
        }
    }
}