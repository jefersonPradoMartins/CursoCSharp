using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaWhile {

        public static void Executar() {

            int palpite = 0;
            Random random= new Random();
            int numeroSecreto = random.Next(1,16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes> 0&& !numeroEncontrado) {
                Console.Write("INseria o seu palpite ");
                string entrada = Console.ReadLine();    
                int.TryParse(entrada, out palpite);
                
                tentativas ++;
                tentativasRestantes --;

                if(numeroSecreto ==palpite) {
                    numeroEncontrado=true;
                    var corAmterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas",tentativas  );
                    Console.BackgroundColor=corAmterior;
                }else if(palpite > numeroSecreto) {
                    Console.WriteLine("Menor tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}",tentativas);
                } else {
                    Console.WriteLine("Maior tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}",tentativas);
                }
            }

        }
    }
}
