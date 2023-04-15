using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    internal class Diretorios {
       // C:\Users\JEFERSON-CASA\projeto\CursoCSharp\CursoCSharp.sln
        public static void Executar() {
            var novoDir = @"~/projeto/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/projeto/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/projeto/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir)){
                Directory.Delete(novoDir,true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }


            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine(" == Pastas ==");
            
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);

            }

            Console.WriteLine("== Arquivos ==");

            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }


            try {
                Directory.Move(novoDir, novoDirDestino);

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

          

        }


       
    }
}
