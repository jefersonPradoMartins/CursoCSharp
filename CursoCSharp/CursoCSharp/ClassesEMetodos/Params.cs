namespace CursoCSharp.ClassesEMetodos {


    internal class Params {

        public static void Recepcionar(params string[] pessoas) {
            foreach(var pe in pessoas) {
                Console.WriteLine($"Olá {pe}");
            }

        }

        public static void Executar() {

            Recepcionar("Pedro", "Manu", "Rosa", "Bia");
        }
    }
}
