﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim...";
        }

        public class Samsung : Celular {
            public override string Assistente() {
                return "Ola! Meu nome é Bixby!";
            }
        }

        public class Iphone : Celular {
            public override string Assistente() {
                return "Ola! Meu nome é Siri!";
            }
        }
    }
    internal class Abstract {

        public static void Executar() {
            var celulares = new List<Celular> {
                new Celular.Iphone(),
                new Celular.Samsung(),

            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
