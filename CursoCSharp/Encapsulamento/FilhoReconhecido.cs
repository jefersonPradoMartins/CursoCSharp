using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {

    public class FilhoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido");

            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamalia);
            //Console.WriteLine(UsaMuitoPhotoshop);

        }

    }
}
