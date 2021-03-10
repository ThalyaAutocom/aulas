using System;
using System.IO;

namespace HTML
{
    public static class Abrir
    {
        public static void AbrirTexto()
        {
            Console.Clear();
            Console.WriteLine("Qual o Caminho do Arquivo? (ex: Caminho+NomeArquvo.txt)");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu.MostrarMenu();
        }
    }

}