using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraEstatica {

        // metodo de classe ou metodo estatica
        public static int Multiplicar (int a, int b) {
            return a * b;
        }

        // metodo de instancia   
        public int Somar(int a, int b) {
            return a * b;
        }

    }

    class MetodosEstatica 
    {
        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2,2));

        }


    }
}
