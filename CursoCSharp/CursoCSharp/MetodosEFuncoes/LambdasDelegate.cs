using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacacao(double x,double y);

    internal class LambdasDelegate {

        public static void Executar() {
            Operacacao sum = (x,y)=> x+ y;
            Operacacao sub = (x,y)=> x- y;
            Operacacao mult = (x,y)=> x*y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(3,3));
            Console.WriteLine(mult(3,3));

        }
    }
}
