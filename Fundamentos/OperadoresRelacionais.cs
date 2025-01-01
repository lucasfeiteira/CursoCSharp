
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {

        public static void Executar() {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("nota invalida? {0}", nota > 10.0);
            Console.WriteLine("nota invalida? {0}", nota < 0.0);
            Console.WriteLine("perfeito? {0}", nota == 10.0);
            Console.WriteLine("tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("qual por media? {0}", nota >= notaDeCorte);
            Console.WriteLine("recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("reprovado? {0}", nota < 3.0);
        }

    }
}
