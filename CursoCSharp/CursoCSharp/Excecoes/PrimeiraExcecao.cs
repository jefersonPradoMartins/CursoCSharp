﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if(valor > Saldo) {
                throw new ArgumentException();
            }
        }

    }
    internal class PrimeiraExcecao {

        public static void Executar() {
            Conta conta = new Conta(100);
            try {
                int.Parse("abc");

                conta.Sacar(1000);
                Console.WriteLine("Retirada com sucesso!");
            }catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            } finally {
                Console.WriteLine("Obrigado!");
            }
           
           
        }


    }
}
