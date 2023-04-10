using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosPorReferencia {

         public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }
        
        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
             numero1 = numero1 + 1000;
             numero2 = numero2 + 1000;
        }


        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine("A: {0}",a);

           
            AlterarOut(out int b, out int c);
            Console.WriteLine("B: {0} {1}",b,c);

        }
    }
}
