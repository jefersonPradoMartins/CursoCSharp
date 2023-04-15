using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Nullables {

        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;
            // são essas as duas possibilidades de criar nullo
            //navegação segura - tratar possiveis nulos
            if(num1.HasValue) {
                Console.WriteLine("Valor de num: {0}",num1);
            } else {
                Console.WriteLine("A Variável não possui valor.");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try {
                int x = num1.GetValueOrDefault(); int y = num2.GetValueOrDefault();
                Console.WriteLine(x+y);

            }catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
