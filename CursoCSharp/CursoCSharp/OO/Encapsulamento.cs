using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encapsulamento;

namespace CursoCSharp.OO {
    internal class Encapsulamento {

        public class FilhoNaoReconhecido : SubCelebridade {
            public new void MeusAcessos() {
                Console.WriteLine("FilhoNãoRechecido");

                Console.WriteLine(infoPublica);
                Console.WriteLine(CorDoOlho);
                //Console.WriteLine(NumeroCelular);
                Console.WriteLine(JeitoDeFalar);
                // Console.WriteLine(SegredoFamilia);
                // Console.WriteLine(UsaMuitoPhotoshop);


            }
        }

        public class AmigoDistante {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos() {
                Console.WriteLine("Amigo Distante");

                Console.WriteLine(amiga.infoPublica);
                // Console.WriteLine(amiga.CorDoOlho);
                //Console.WriteLine(amiga.NumeroCelular);
                //   Console.WriteLine(amiga.JeitoDeFalar);
                // Console.WriteLine(amiga.SegredoFamilia);
                // Console.WriteLineamiga.(UsaMuitoPhotoshop);



            }
        }

            public static void Executar() {
                SubCelebridade sub = new SubCelebridade();
                sub.MeusAcessos();


                new FilhoReconhecido().MeusAcessos();
                new AmigoDistante().MeusAcessos();


                new FilhoNaoReconhecido().MeusAcessos();
                new AmigoDistante().MeusAcessos();
            }
        }
    
}
