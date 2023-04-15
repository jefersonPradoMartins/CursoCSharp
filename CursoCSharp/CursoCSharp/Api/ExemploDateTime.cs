using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    internal class ExemploDateTime {

        public static void Executar() {

            var dateTime = new DateTime(year:2030, month:1, day:1);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var agora = DateTime.Now;
            Console.WriteLine(agora);

            var amanha = hoje.AddDays(1);
            Console.WriteLine(amanha.Day);

            var ontem = hoje.AddDays(-1);
            Console.WriteLine(ontem.Day);

            Console.WriteLine(hoje.ToString("dd"));
            Console.WriteLine(hoje.ToString("d"));
            Console.WriteLine(hoje.ToString("D"));
            Console.WriteLine(hoje.ToString("g"));
            Console.WriteLine(hoje.ToString("G"));


        }
    }
}
