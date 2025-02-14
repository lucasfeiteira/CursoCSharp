using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class ExemploPath {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine("Extension: " + Path.GetExtension(arquivo));
            Console.WriteLine("Nome: " + Path.GetFileName(arquivo));
            Console.WriteLine("Nome Extensao: " + Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine("Nome Diterio: " + Path.GetDirectoryName(arquivo));
            Console.WriteLine("Tem Verdade: " + Path.HasExtension(arquivo));
            
            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
