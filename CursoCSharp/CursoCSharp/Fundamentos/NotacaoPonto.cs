using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {

        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World")
                .Replace("World", "Mundo!");
            Console.WriteLine(saudacao);
            //o ponto no final permite adicionar mais funções ao codigo que
            //esta em uso.


            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // esse ? no código é para permitir uma navegação segura.

        }

    }
}
