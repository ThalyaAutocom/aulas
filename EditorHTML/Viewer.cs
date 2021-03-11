using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Open()
        {
            Console.Clear();
            Console.WriteLine(" Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Show(text.ToString());
            }

        }
        public static void Show(string text)
        {
            Console.Clear();
            Console.WriteLine("        MODO VISUALIZAÇÃO       ");
            Console.WriteLine("--------------------------------");
            Replace(text);
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Aperte 'Enter' para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text)
        {
            var blue = new Regex(@"<\s*blue[^>]*>(.*?)<\s*/\s*blue>");
            var red = new Regex(@"<\s*red[^>]*>(.*?)<\s*/\s*red>");
            var pink = new Regex(@"<\s*pink[^>]*>(.*?)<\s*/\s*pink>");
            var words = text.Split(' ');


            for (var i = 0; i < words.Length; i++)
            {
                if (blue.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }else 
                if (red.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }else if (pink.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}