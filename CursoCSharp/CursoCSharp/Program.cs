using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notacão Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormantandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                { "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                { "Operadores Ternários - Fundamentos", OperadorTernario.Executar },

               //Estrutura de controle
                { "Estrutura If - Estrutura de Controle ", EstruturaIf.Executar },
                { "Estrutura If/Else - Estrutura de Controle ", EstruturasIfElse.Executar },
                { "Estrutura If/Else/If - Estrutura de Controle ", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estrutura de Controle ", EstruturaSwitch.Executar },
                { "Estrutura While - Estrutura de Controle ", EstruturaWhile.Executar },
                { "Estrutura Do While - Estrutura de Controle ", EstruturaDoWhile.Executar },
                { "Estrutura For - Estrutura de Controle ", EstruturaFor.Executar },
                { "Estrutura Foreach - Estrutura de Controle ", EstruturaForeach.Executar },
                { "Usando Break - Estrutura de Controle ", EstruturaUsandoBreak.Executar },
                
                
                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar },
                { "Construtores - Classes e Métodos", Construtores.Executar },
                { "Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                { "Params - Classes e Métodos", Params.Executar },
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                { "Get Set - Classes e Métodos", GetSet.Executar },
                { "Props - Classes e Métodos", Props.Executar },
                { "Readonly - Classes e Métodos", Readonly.Executar },
                { "Enum - Classes e Métodos", ExemploEnum.Executar },
                { "Struct - Classes e Métodos", ExemploStruct.Executar },
                { "Struct vs Classe - Classes e Métodos", StructVsClasse.Executar },
                { "Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                { "Paramêtros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                { "Paramêtro Padrão - Classes e Métodos", ParametroPadrao.Executar },
                
                // Coleções 
                { "Array - Coleções", Colecoes.Array.Executar },
                { "Coleções List - Coleções", Colecoes.ColecoesList.Executar }





            }) ;

            central.SelecionarEExecutar();
        }
    }
}