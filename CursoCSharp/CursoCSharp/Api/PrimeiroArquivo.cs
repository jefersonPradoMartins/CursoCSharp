namespace CursoCSharp.Api {
    public static class ExtensaoString { 
    public static string ParseHome(this string path) {
        string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
            Environment.OSVersion.Platform == PlatformID.Other)
            ? Environment.GetEnvironmentVariable("HOME")
            : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        return path.Replace("~", home);
    }
    }
    internal class PrimeiroArquivo {      

        public static void Executar() {

            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if(!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) { 
                    sw.WriteLine("Esse é");
                    sw.WriteLine("O Nosso");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("Arquivo");
                }
            }
            using (StreamWriter sw =  File.AppendText (path)) {
                sw.WriteLine("");
                sw.WriteLine("Adicionar");
                sw.WriteLine("Mais informação");
            }

        }
    }
}
