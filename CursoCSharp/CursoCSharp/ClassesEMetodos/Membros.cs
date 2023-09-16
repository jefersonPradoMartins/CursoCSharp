namespace CursoCSharp.ClassesEMetodos {
     class Membros {


        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            // Console.WriteLine($"{sicrano.Nome} tem " +
            //   $"{sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var funalo = new Pessoa();
            funalo.Nome = "Bruno";
            funalo.Idade = 32;

            var apresentacaoDoFulano = funalo.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);

            Console.WriteLine(apresentacaoDoFulano);


        }

       


    }
}
