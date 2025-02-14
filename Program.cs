using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api; 
using CursoCSharp.LINQ; 


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle 
                {"Estruturas de If - Estruturas de Controle ", EstruturasIf.Executar},
                {"Estruturas de If/Else - Estruturas de Controle ", EstruturasIfElse.Executar},
                {"Estruturas de If/Else/If - Estruturas de Controle ", EstruturaIfElseIf.Executar},
                {"Estruturas de Switch - Estruturas de Controle ", EstruturaIfElseIf.Executar},
                {"Estruturas While - Estruturas de Controle ", EstruturasWhile.Executar},
                {"Estruturas do While - Estruturas de Controle ", EstruturasDoWhile.Executar},
                {"Estruturas de For - Estruturas de Controle ", EstruturaFor.Executar},
                {"Estruturas de ForEach - Estruturas de Controle ", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle ", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle ", UsandoContinue.Executar},
               
                
                // Classes e Metodos 
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estatica - Classes e Metodos", MetodosEstatica.Executar},
                {"Atributos Estatica - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"ReadOnly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classes - Classes e Metodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},
                
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                
                //OO
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // Metodos e Funcoes
                {"Exemplo Lambda - Metodos & Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegates - Metodos & Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Metodos & Funções", UsandoDelegates.Executar},
                {"Delegates Como Função Anonima - Metodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates Como Parametros - Metodos & Funções", DelegatesComoParametros.Executar},
                {"Metodos De Extensao - Metodos & Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Execeções - Execeções", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Execeções", ExcecoesPersonalizadas.Executar},
                
                // Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                
                
                //LINQ #1
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}