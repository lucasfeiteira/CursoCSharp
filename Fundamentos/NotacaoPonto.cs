using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "ola".ToUpper().Insert(3, "world!").Replace("world", "mundo");

            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length);
        
        }
    }
}
