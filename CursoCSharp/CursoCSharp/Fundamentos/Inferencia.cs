using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {

        public static void Executar() {

            var nome = "Leonardo";
            Console.WriteLine("Nome "+nome);

            // nome = 123;  o erro é devido o nome sera associado a string
            //e depois querer associar a int. não pode pois a inferencia não permite

            var idade = 32;
            Console.WriteLine("Idade "+idade);

            /*
            var idade;
            idade = 32;
            esse comando apresenta erro pois para variveis de tipo implicito 
            precisa já colocar um valor.
            */



        }
    }
}
