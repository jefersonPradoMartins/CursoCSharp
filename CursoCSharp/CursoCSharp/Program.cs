using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormantandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                { "Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                { "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                { "Operadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                { "Operadores Ternarios - Fundamentos", OperadorTernario.Executar },

               //Estrutura de controle
                { "Estrutura If - Estrutura de Controle ", EstruturaIf.Executar },
                { "Estrutura If/Else - Estrutura de Controle ", EstruturasIfElse.Executar },
                { "Estrutura If/Else/If - Estrutura de Controle ", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estrutura de Controle ", EstruturaSwitch.Executar },
                { "Estrutura While - Estrutura de Controle ", EstruturaWhile.Executar },
                { "Estrutura Do While - Estrutura de Controle ", EstruturaDoWhile.Executar },
                { "Estrutura For - Estrutura de Controle ", EstruturaFor.Executar },
                { "Estrutura Foreach - Estrutura de Controle ", EstruturaForeach.Executar },
                { "Usando Break - Estrutura de Controle ", EstruturaUsandoBreak.Executar }
                
           
            
            
            
            
            
            });

            central.SelecionarEExecutar();
        }
    }
}