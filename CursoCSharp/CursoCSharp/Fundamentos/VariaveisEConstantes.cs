using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

     class VariaveisEConstantes {


        public static void Executar() {


            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415
            double area = PI * raio * raio;

            System.Console.WriteLine(area);
            Console.WriteLine("Área é " + area + 1000);


            bool estaChovendo = false;
            Console.WriteLine("Está chovendo " + estaChovendo);


            byte idade = 45; //só aceita valores positivos.

            Console.WriteLine("idade "+idade);


            sbyte saldoDeGols = sbyte.MinValue; // aceita número negativo e positivo.
            Console.WriteLine("Saldo de Gols "+saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário "+salario);

            int menorValorInt = int.MinValue; // mais usado dos internos.
            Console.WriteLine("Menor int "+menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira "+populacaoBrasileira);


            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial "+populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " +precoComputador); // Double cabe o dobro d informação do float

            double valorDeMercadoDaApple = 1000000000000.00;
            Console.WriteLine("Valor de Mercado da Apple"+ valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas"+distanciaEntreEstrelas);

            char letra = 'A';
            Console.WriteLine("Letra "+letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine("Texto  "+texto);








        }

     

    }
}
