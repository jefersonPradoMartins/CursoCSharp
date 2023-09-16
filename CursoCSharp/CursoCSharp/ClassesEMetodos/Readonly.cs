namespace CursoCSharp.ClassesEMetodos {
    internal class Readonly {

        public class Cliente {
            public string Nome;
           readonly DateTime Nascimento;
        
            public Cliente() { }
            public Cliente(string nome, DateTime nascimento) {
                this.Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNasciomento() {
                return String.Format("{0}/{1}/{2}", Nascimento.Day
                    , Nascimento.Month, Nascimento.Year);
            }
        
        }

        public static void Executar() { 
         var novoCliente = new Cliente("Ana Silva", new DateTime(1997,5,25));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNasciomento());
        
        }
    }
}
