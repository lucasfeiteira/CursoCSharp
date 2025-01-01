using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {

        public static void Executar() {
            var palavras = "Opa!";

            foreach (var letra in palavras){
                Console.WriteLine(letra);
                
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
