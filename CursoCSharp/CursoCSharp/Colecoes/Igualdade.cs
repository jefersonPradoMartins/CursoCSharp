namespace CursoCSharp.Colecoes {
    internal class Igualdade {

        public static void Executar() {
            var p1 = new Produto("Caneta", 1.0);
            var p2 = new Produto("Caneta", 1.0);

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1 == p2);
            // resultado é false, pois esta comparando o endereço 
            // da memoria          

        }
    }
}
