using System;
using System.IO;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("        MODO EDITOR       ");
            Console.WriteLine("--------------------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);



            EscolhaSalvar(file.ToString());
            Viewer.Show(file.ToString());

            

        }
        public static void EscolhaSalvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Deseja Salvar o arquivo?");
            Console.WriteLine("1 - Sim, 2 - Não");
            Console.Write("Opção: ");
            short escolha = short.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Qual o caminho para Salvar o arquivo? (ex: Caminho+NomeArquvo.txt)");
                var caminho = Console.ReadLine();

                using (var file = new StreamWriter(caminho))
                {
                    file.Write(texto);
                }
                Console.WriteLine($"Arquivo salvo no caminho {caminho}");
                // Console.WriteLine("Aperte 'Enter' para voltar ao menu");
                // Console.ReadLine();
                // Menu.Show();

            }
            else Menu.Show();
        }
    }
}