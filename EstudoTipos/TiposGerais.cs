using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoTipos
{
    public static class TiposGerais
    {
        public static void TipoParaMoedas()
        {
            Console.Clear();
            //tipo decimal, deve colocar o m no final do valor
            var valor = 10536.25m;
            
            // Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("en-US")));
            // Console.WriteLine(valor.ToString("C"));
            
            //Arredondar valor normalmente
            Console.WriteLine(Math.Round(valor)); 
            //Arredondar valor para cima
            Console.WriteLine(Math.Ceiling(valor)); 
            //Arredondar valor para baixo
            Console.WriteLine(Math.Floor(valor)); 

        }

        public static void EstudarArray()
        {
            Console.Clear();

            var meuArray = new int[5];
            var meuSegundoArray = new int[5]{1, 2, 3, 4, 5};

            meuArray[0] = 12;

            Console.WriteLine("------------------------");
            Console.WriteLine("Percorrendo com for: ");
            Console.WriteLine("------------------------");
            for (int i = 0; i < meuSegundoArray.Length; i++)
            {
                Console.WriteLine(meuSegundoArray[i]);;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Percorrendo com foreach: ");
            Console.WriteLine("------------------------");
            foreach (var item in meuSegundoArray)
            {
                Console.WriteLine(item);;
            }
        }
       
    }
}