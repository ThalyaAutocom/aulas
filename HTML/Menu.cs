using System;

namespace HTML
{
    public static class Menu
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Editor HTML");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Escolha uma Opção:");
            Console.WriteLine("1 - Novo Arquivo");
            Console.WriteLine("2 - Abrir Arquivo Existente");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("----------------------------");
            Console.Write("Opção: ");


            var opcao = short.Parse(Console.ReadLine());
            SelecionarMenu(opcao);
        }
        public static void SelecionarMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: NovoArquivo.Novo(); break; ;
                case 2: Abrir.AbrirTexto(); break;
                case 3: System.Environment.Exit(0); break;
                default: MostrarMenu(); break;
            }
        }
    }
}