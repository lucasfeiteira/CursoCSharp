﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {

        public static void Recepcionar(params string[] pessoas) {

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("ola {0}", pessoa);
            }
        }

        public static void Executar() {

            Recepcionar("pedro", "manu", "roger", "ana", "bia");

        }
    }
}
