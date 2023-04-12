using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;

        int VelocidadeAtual;
        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;

        }




        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;

            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }             
    }
    public class Uno : Carro {
        public Uno() : base(velocidadeMaxima: 200) {
        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(velocidadeMaxima: 350){
            }
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    internal class Heranca {

            public static void Executar() {

            Console.WriteLine("Uno Acelerando com escada");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari do Tiago Fintch Acelerando");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Carro 3");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Carro 4");
            Carro carro4 = new Uno();
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());



        }
    }
}
