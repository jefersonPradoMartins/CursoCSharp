using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosNomeados {

        public static void Formatar(int dia,int mes, int ano) {

            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }

        public static void Executar() {
            Formatar(mes:1,dia:6,ano: 1996);
        }
    }
}
