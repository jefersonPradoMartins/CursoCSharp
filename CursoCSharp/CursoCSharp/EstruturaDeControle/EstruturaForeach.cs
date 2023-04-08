using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForeach {

        public static void Executar() {

            var palavar = "opa";

            foreach(var letra in palavar) {

                Console.WriteLine(letra);
            }

            var alunos = new String[] { "Ana", "Bia", "Carlos" };

            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }

    }
}
