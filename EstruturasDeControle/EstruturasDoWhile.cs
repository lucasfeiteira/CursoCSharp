using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturasDoWhile {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("seja bem-vindo {0}", entrada);
                Console.WriteLine("deseja continuar? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");


        }
    }
}
