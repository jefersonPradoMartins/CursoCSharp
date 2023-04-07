using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {

        public static void Executar() {

            var exetouTrabalho1 = true;
            var exetouTrabalho2 = false;


            bool comprouTv50 = exetouTrabalho1 && exetouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}",comprouTv50);

            var comprouSorvete = exetouTrabalho1|| exetouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = exetouTrabalho1 ^ exetouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}",comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);



        }
    }
}
