using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class UsandoDelegates {
    
        delegate double Soma(double a, double b);

        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }
        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a+b);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(3,3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(3,3);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(3,3));

            Action<double,double> op4 = MeuImprimirSoma;
            op4(6,6);
        }
    }
}
