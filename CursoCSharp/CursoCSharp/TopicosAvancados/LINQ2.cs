using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class LINQ2 {
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
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno não encontrado!");
            }
            var ana = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Ana"));
            Console.WriteLine(ana);
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nota.Equals("Ana"));
            Console.WriteLine(outraAna);
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Ana"));
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip) {
                Console.WriteLine($"{item.Nome} {item.Nota} {item.Idade}");
            }
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);
            var mediaDaTurma = alunos.Where(a => a.Nota > 3).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
