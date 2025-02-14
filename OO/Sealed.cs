using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortura() {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HondarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HondarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
    //    public override bool HondarNomeFamilia() {

    //    }
    }

    internal class Sealed {

        
        public static void Executar() {

            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortura());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HondarNomeFamilia());
        }
    }
}
