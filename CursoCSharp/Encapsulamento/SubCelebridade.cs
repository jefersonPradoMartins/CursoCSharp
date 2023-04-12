using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {

        // todos
        public string infoPublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)

        internal ulong NumeroCelular = 55119999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamalia = "Bla bla";

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade");

            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamalia);
            Console.WriteLine(UsaMuitoPhotoshop);

        }

    }
}
