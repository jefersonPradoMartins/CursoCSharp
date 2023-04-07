using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormantandoNumero {

        public static void Executar() {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culturapt = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", culturapt));
            CultureInfo culturaen = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", culturaen));

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10"));
            //completar com zeros 

        }
    }
}
