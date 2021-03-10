using System;
using System.IO;

namespace HTML
{
    public static class NovoArquivo
    {
        public static void Novo()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            EscolhaSalvar(texto);

        }
        public static void EscolhaSalvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Deseja Salvar o arquivo?");
            Console.WriteLine("1 - Sim, 2 - Não");
            short escolha = short.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Qual o caminho para Salvar o arquivo? (ex: Caminho+NomeArquvo.txt)");
                var caminho = Console.ReadLine();

                using (var arquivo = new StreamWriter(caminho))
                {
                    arquivo.Write(texto);
                }
                Console.WriteLine($"Arquivo salvo no caminho {caminho}");
                Console.ReadLine();
                Menu.MostrarMenu();

            }
            else Menu.MostrarMenu();
        }
    }
}