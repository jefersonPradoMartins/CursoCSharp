using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    public class Produto {


    public string Nome;
    public double Preco;

    public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override bool Equals(object? obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }

    internal class ColecoesList {

        public static void Executar() {

            var livro = new Produto("Game of Thrones", 49.0);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto ("Camisa",29.9),
            new Produto("8 temporada Game of Thrones",89.9),
            new Produto("Poster",11)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");

            }

        }
    }
}
