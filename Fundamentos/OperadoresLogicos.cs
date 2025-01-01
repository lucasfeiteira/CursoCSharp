using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {

        public static void Executar(){

            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("comprou a TV 50? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("comprou o sorvete? {0}", comprouSorvete );

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("comprou a tv 32? {0}", comprouTV32);
            
            
            Console.WriteLine("mais saudavel? {0}", !comprouSorvete);
        }
    }
}
