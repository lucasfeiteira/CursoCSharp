using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia

            double raio = 4.5;

            const double PI = 3.14;

            raio = 5.5;

            // PI = 3.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("area é " + area);

            // tipos internos 

            bool estaChovendo = false;
            Console.WriteLine("esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols  " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("preco computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("valor apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "seja bem-vindo ao curso de C#";
            Console.WriteLine(texto);


        }
    }
}
