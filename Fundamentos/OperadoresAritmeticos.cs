using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {

        public static void Executar() {

            //preco desconto
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("o preco final é {0}", totalComDesconto);

            //IMC 
            double peso = 91.8;
            var altura = 1.82;
            var imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            //numero par/impor 

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par , par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar , impar % 2);

        }

    }
}
