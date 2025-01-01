using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {

        public static void Executar() {

            var nota = 9.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "aprovado" : "reprovado";

            Console.WriteLine(resultado);
        }

    }
}
