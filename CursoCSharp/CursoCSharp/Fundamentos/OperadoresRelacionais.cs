﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {

        public static void Executar() {



            //double nota = 6.0;
            Console.Write("Digite a Nota: ");
            double.TryParse(Console.ReadLine(), out Double nota);

            double notaDeCorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota ==10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}",nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0) ;

            // os resultados operacionais vão
            // produzir resultados true or false
        }
    }
}
