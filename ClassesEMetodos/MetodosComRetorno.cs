using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar (int a, int b) {
            return a + b;
        }

        public int Subtrair (int a , int b) {
            return a - b;
        }

        public int Multiplicar (int a , int b) {
            return a * b;
        }

    }

    class CalculadoraCadeira {
        int memoria;

        public CalculadoraCadeira Somar(int a) {
            
            memoria += a;
            return this;
        }

        public CalculadoraCadeira Multiplicar (int a) {

            memoria *= a;
            return this;
        }

        public CalculadoraCadeira Limpar () {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeira Imprimir() {
            Console.WriteLine("Imprimir: "+ memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }
    
    internal class MetodosComRetorno {

        public static void Executar() {

            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(4,4));

            var calculadoraCadeia = new CalculadoraCadeira();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);


        }
    }
}
