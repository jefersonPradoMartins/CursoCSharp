﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Dynamics {

        public static void Executar() {
            dynamic meuObjeto = "teste";
            // meuObjeto = 3;

          // meuObjeto++;
         //   Console.WriteLine(meuObjeto);

          dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria";
            aluno.nota = 8.2;
            aluno.idade = 25;

            Console.WriteLine($"{aluno.nome } {aluno.nota } {aluno.idade}");
        }
    }
}
