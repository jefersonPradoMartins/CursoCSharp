using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto() { }
        public Moto(string marca, string modelo,int cilindrada) {
            SetMarca(marca);
           SetModelo(modelo);
           SetCilindrada(cilindrada);
        }

        public string GetMarca() {
            return Marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public int GetCilindrada() {
            return Cilindrada;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public void SetCilindrada(int cilindrada) {
            if(cilindrada < 0) {
                cilindrada= 0;
            } else {
                Cilindrada = cilindrada;
            }
           
        }

    }


    internal class GetSet {

        public static void Executar() {


            var moto1 = new Moto("Kawasaki","Ninja 300", 300);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);

            Console.WriteLine("Marca: {0} Modelo: {1}" +
                " Cilindrada: {2}",moto2.GetMarca(), moto2.GetModelo(), moto2.GetCilindrada()) ;

        }
    }
}
