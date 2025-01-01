using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturasIfElse {

        public static void Executar() {

            double nota = 7.0;

            if (nota >= 7.0){
                Console.WriteLine("aprovado");
                Console.WriteLine("nao fez mais que sua obrigaçao..");
            } else {
                Console.WriteLine("recuperação");
            }
        }
    }
}
