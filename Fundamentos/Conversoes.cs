using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {

        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("nota truncada: {0} ", notaTruncada);

            Console.Write("digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserido: {0}",idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("resultado: {0}", idadeInteiro);

            Console.Write("digite o primeiro numero: ");
            string palavras = Console.ReadLine();
            int numero1;
            int.TryParse(palavras, out numero1);
            Console.WriteLine("resultado {0}", numero1);


            Console.Write("digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("resultado {0}", numero2);



        }
    }
}
