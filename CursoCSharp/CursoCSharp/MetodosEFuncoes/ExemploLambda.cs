using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class ExemploLambda {

        public static void Executar() {

            // action não tem retorno mas func tem 
            Action algonoConsole = () => {
                Console.WriteLine("Lambda Com c#!" );

            };

            algonoConsole();
            //esse int siguinifica que o retorno é int
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());
            //a entrada é int, e o retorno é string 
            Func<int, string> conversorHex = (numero) => {
                return numero.ToString("X");
            };

            Console.WriteLine(conversorHex(1234));
            // anetrada é 3 int e o retorno é string
            Func<int, int, int, string> fomtarData = (dia, mes, ano) => 
               String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
                Console.WriteLine(fomtarData(1,1,2018));


        }
    }
}
