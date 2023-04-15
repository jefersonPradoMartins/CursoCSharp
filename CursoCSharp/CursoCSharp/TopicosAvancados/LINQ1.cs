using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class LINQ1 {

        class aluno {
            public string Nome;
            public int Idade;
            public double Nota;
        }


        public static void Executar() {

            var alunos = new List<aluno> {
                new aluno () {Nome = "Pedro", Idade = 25, Nota = 8.0},
                new aluno () {Nome = "Andre", Idade = 15, Nota = 6.0},
                new aluno () {Nome = "Maria", Idade = 45, Nota = 3.0},
                new aluno () {Nome = "Ana", Idade = 65, Nota = 2.0},
                new aluno () {Nome = "Keuly", Idade = 35, Nota = 8.0},
                new aluno () {Nome = "Ana", Idade = 25, Nota = 1.0},
                new aluno () {Nome = "Marcio", Idade = 28, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados ==");
            var aprovados = alunos.Where(a => a.Idade > 10)
                .OrderBy(a => a.Nome);
            foreach (var aluno in aprovados) {
                Console.WriteLine($"{aluno.Nome} {aluno.Idade} {aluno.Nota}");
            }


            Console.WriteLine("\n== Chamada ===");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n == Aprovados (por idade) ==");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome;
            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
