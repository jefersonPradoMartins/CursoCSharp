using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {

        public static void Executar() {

            string[] alunos = new string[5];
            alunos[0] = "Bia";
            alunos[1] = "Rafael";
            alunos[2] = "Renan";
            alunos[3] = "Lela";
            alunos[4] = "Jeferson";


            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.5, 3.3, 1.2, 6.5, 0 };

            foreach(var nota in notas) {
                somatorio+= nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letas = { 'a', 'b', 'c' };
            string palavra = new string(letas);
            Console.WriteLine(palavra);


        }
    }
}
