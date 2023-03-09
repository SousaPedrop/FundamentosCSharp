using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoTipos
{
    public static class TipoData
    {
        public static void EstudarDatas()
        {
            Console.Clear();            
            // var data = new DateTime();
            // var data = new DateTime(2023,10,12, 13, 23, 14);
            var dataAtual = DateTime.Now;

            var dataUtc = DateTime.UtcNow;
            Console.WriteLine(dataUtc);
            Console.WriteLine(dataUtc.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var dataAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezoneAustralia);
            Console.WriteLine(dataAustralia.ToString(new CultureInfo("en-US")));

            var timeSpan = new TimeSpan(10, 20, 30); //usado para data + específica / sensivel
            Console.WriteLine(timeSpan);

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(DateTime.IsLeapYear(2020));
            Console.WriteLine(DateTime.IsLeapYear(2022));

            /*      --- Pegando valores isolados ---
                Console.WriteLine(dataAtual.Day);
                Console.WriteLine(dataAtual.DayOfWeek);
                Console.WriteLine(dataAtual.DayOfYear);
                Console.WriteLine(dataAtual.Month);
                Console.WriteLine(dataAtual.Year);
                Console.WriteLine(dataAtual.Hour);
                Console.WriteLine(dataAtual.Minute);
                Console.WriteLine(dataAtual.Second);
                var dia = dataAtual.Day + 2;
                var dia = dataAtual.AddDays(2);
            */

            /*      --- Escolhendo a Cultura para exibição da Data ---
                var culturaEn = new CultureInfo("en-US");
                var culturaDe = new CultureInfo("de-DE");

                Console.WriteLine(dataAtual.ToString(culturaEn));
                Console.WriteLine(dataAtual.ToString(culturaDe));
                Console.WriteLine(dataAtual.ToString("D", culturaEn));
                Console.WriteLine(dataAtual.ToString("D", culturaDe));
            */
        }

        private static string FormatarData(DateTime data)
        {
            // Y - year - ano    MM - Month - minuto   D - Day - dia
            //      mm - minutes - minutos    s - second - segundos
            // var formatada = String.Format("{0:y}",dataAtual);
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss zzz}",dataAtual);
            // var formatada = String.Format("{0:s}",dataAtual);
            // formatada = String.Format("{0:u}",dataAtual);
            // Console.WriteLine(formatada);
            // Console.WriteLine(dataAtual.ToString("MM/dd/yyyy"));
            // Console.WriteLine(dataAtual.ToString("s"));
            // return formatada;
            return data.ToString("u");
        }
    }
}