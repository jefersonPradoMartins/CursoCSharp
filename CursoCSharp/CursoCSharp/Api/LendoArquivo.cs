namespace CursoCSharp.Api {
    internal class LendoArquivo {

        public static void Executar() {

            var path = @"~/lendo_arquivos.txt".ParseHome();

            if(!File.Exists(path)) {

           
            using(StreamWriter sw  = File.CreateText(path)) {
                sw.WriteLine("Produto;Preco;qtde");
                sw.WriteLine("Caneta Bic Preta; 3.99;26");
                sw.WriteLine("Borracha Branca; 2.55; 25");
            }
            }

            try {
                using(StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
