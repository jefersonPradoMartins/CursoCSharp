using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesDictionary {

        public static void Executar() {

            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os incriveis");
            filmes.Add(2009, "Sehor dos Aneis");


            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004 " + filmes[2004]);
                Console.WriteLine("2004 " + filmes.GetValueOrDefault(2008));
            }

            Console.WriteLine(filmes.ContainsValue("Lost"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");


            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach(var item in filmes.Keys ) {
                Console.WriteLine(item.ToString());
            }

            foreach(var item in filmes.Values ) {
                Console.WriteLine(item);
            }

            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

        }

    }
}
