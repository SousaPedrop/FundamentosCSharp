using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoTipos
{
    public static class Excecoes
    {
        public static void TratarExcecoes()
        {
            var arr = new int[3];

            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     Console.WriteLine(arr[i]);
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Indice não encontrado.");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar o texto.");
            }
            catch (MinhaExcecao ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.quandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Alguma coisa deu errado.");
            }
            finally
            {
                Console.WriteLine("Finalmente acaboua");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (String.IsNullOrEmpty(texto))
            {
                // throw new Exception("O texto não pode ser nulo ou vazio");
                throw new MinhaExcecao();
            }
        }

        private class MinhaExcecao : Exception
        {
            public DateTime quandoAconteceu {get; set; }

            public MinhaExcecao()
            {
                quandoAconteceu = DateTime.Now;
            }
        }

    }
}