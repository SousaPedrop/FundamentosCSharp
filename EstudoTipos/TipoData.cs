using System;
using System.Collections.Generic;
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
            var data = new DateTime(2023,10,12, 13, 23, 14);
            var dataAtual = DateTime.Now;

            // Console.WriteLine(dataAtual);
            // Console.WriteLine(data);
            // Console.WriteLine(dataAtual.Day);
            // Console.WriteLine(dataAtual.DayOfWeek);
            // Console.WriteLine(dataAtual.DayOfYear);
            // Console.WriteLine(dataAtual.Month);
            // Console.WriteLine(dataAtual.Year);
            // Console.WriteLine(dataAtual.Hour);
            // Console.WriteLine(dataAtual.Minute);
            // Console.WriteLine(dataAtual.Second);

            // Y - year - ano    MM - Month - minuto   D - Day - dia
            //      mm - minutes - minutos    s - second - segundos
            // var formatada = String.Format("{0:y}",dataAtual);
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss zzz}",dataAtual);
            var formatada = String.Format("{0:s}",dataAtual);
            formatada = String.Format("{0:u}",dataAtual);
            Console.WriteLine(formatada);
            // Console.WriteLine(dataAtual.ToString("MM/dd/yyyy"));
            Console.WriteLine(dataAtual.ToString("s"));
        }
    }
}