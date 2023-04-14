using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {


    internal class DelegateFunAnonima {

        delegate string StringOperacao(string str);



        public static void Executar() {

            StringOperacao inverter = delegate (string str) {

                char[] chars = str.ToCharArray();
                Array.Reverse(chars);

                return new string(chars);
            };

            Console.WriteLine(inverter("c# é top 10 @"));

        }
    }
}
