namespace CursoCSharp.Colecoes {
    internal class ColecoesSet {

        public static void Executar() {


            var livro = new Produto("Game of Thrones", 49.0);
            var carrinho = new HashSet<Produto>(); // Set não
                                                   // é indexado.
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto ("Camisa",29.9),
            new Produto("8 temporada Game of Thrones",89.9),
            new Produto("Poster",11)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");

            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);


        }
    } 
}
