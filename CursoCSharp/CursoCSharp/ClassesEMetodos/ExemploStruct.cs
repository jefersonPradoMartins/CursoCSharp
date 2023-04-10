using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExemploStruct {

        interface Ponto {
            void MoverNaDiagonal(int Delta);
        }

        struct Coordenada: Ponto {
            public int x;
            public int y;

            public Coordenada(int x, int y) {
                this.x = x;
                this.y = y;
            }

            public void MoverNaDiagonal(int Delta) {
                this.x += Delta;
                this.y += Delta;
            }
        
        }
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.x= 2;
            coordenadaInicial.y= 2;

            Console.WriteLine("Coordernada Inicial");
            Console.WriteLine("X = {0}", coordenadaInicial.x);
            Console.WriteLine("Y = {0}",coordenadaInicial.y);

            var coordenadaFinal = new Coordenada(x:9, y:1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final");
            Console.WriteLine($"X = {coordenadaFinal.x}");
            Console.WriteLine($"Y = {coordenadaFinal.y}");


        }
    }
}
