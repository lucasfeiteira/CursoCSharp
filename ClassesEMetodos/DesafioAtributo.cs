using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    internal class DesafioAtributo {

        int a = 10;

        public static void Executar() {


            //ACESSAR VARIAVEL 'a' dentro do metodo Executar!
            //Console.WriteLine(a);

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
