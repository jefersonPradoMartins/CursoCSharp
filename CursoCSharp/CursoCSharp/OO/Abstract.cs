using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    // classe abstrata é para quando ela não pode ser instanciada
    // por si só, vai deixar instanciar as classes herdeiras da 
    // classe abstrata;
    public abstract class Celular {
        public abstract string Assistente();
        public string Tocar() {
            return "Trim Trim Trimmm";
        }
    }
    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Jarvis!";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá, meu nome é Siri!";
        }
    }
    internal class Abstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Samsung{},new Iphone()
            };
            foreach(var c in celulares) {
                Console.WriteLine(c.Assistente());
            }
        }
    }
}
