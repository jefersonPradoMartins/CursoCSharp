using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    interface OperacaoBinaria {
        abstract int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {return a + b;}
    }
    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {return a - b;}
    }
    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {return a * b;}
    }
    class Calculadora {
      List<OperacaoBinaria> OperacaoList = new List<OperacaoBinaria> {new Soma(),new Multiplicacao(),new Subtracao()};
        public string ExecutarOperacpes(int a, int b) {
            string resultado = "";
            foreach (var op in OperacaoList) {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacpes(1, 2);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
