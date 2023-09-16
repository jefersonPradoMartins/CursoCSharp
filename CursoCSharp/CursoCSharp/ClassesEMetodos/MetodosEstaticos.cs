namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        public  int Somar(int a, int b) { return a * b; }
        public static int Multiplicar(int a,int b) { return a * b; }

    }

    internal class MetodosEstaticos {

        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado {0}",resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado {0}",calc.Somar(2,2));

        }
    }
}
