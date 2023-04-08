using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class UsandoContinue {

        public static void Executar() {

            int intervalo = 50;

            Console.WriteLine("Número pares entre 1 e {0}!",intervalo);

            for(int i=2;i <= intervalo; i+=2) {
                Console.WriteLine(i + " ");
            }

        }
    }
}
