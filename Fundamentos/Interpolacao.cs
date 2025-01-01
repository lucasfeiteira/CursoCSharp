using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {

        public static void Executar() {
            var nome = "notebook gamer";
            var marca = "dell";
            double preco = 5800.00;

            Console.WriteLine("o " + nome + " da marca " + marca + " custa " + preco + "."  );

            Console.WriteLine("o {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"a marca {marca} é legal!");

            Console.WriteLine($" 1 + 1 = { 1+1 }");
        }
    }
}
