using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;

        public Comida (double peso) {
            this.Peso = peso;
        }

        public Comida() { }
    }

    public class Feijao : Comida {
        public Feijao(double peso) : base(peso) { }
    }
    public class Arroz : Comida {}
    public class Carne : Comida {}

    public class Pessoa
    {
        public double Peso;

        //public void Comer (Feijao feijao) {
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida) {
            Peso += comida.Peso;    
        }
    }

    internal class Polimorfismo {

        public static void Executar() { 

            Feijao ingrediente1 = new Feijao(0.3);
            
            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;
            
            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa clinte = new Pessoa();
            clinte.Peso = 80.2;
            clinte.Comer(ingrediente1);
            clinte.Comer(ingrediente2);
            clinte.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {clinte.Peso}Kg!");

        }
    }
}
