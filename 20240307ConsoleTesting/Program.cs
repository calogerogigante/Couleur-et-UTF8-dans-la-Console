using System;
using System.Text;

namespace _20240307ConsoleTesting
{
    internal class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Random rand = new Random();
            int largeurEcran = 0;
            int hauteurEcran = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                largeurEcran = Console.WindowWidth;
                hauteurEcran = Console.WindowHeight;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(largeurEcran + "x" + hauteurEcran);
                Console.Write("#---------#---------#---------#---------#---------#---------#---------#---------#---------#---------#---------#---------");
                Console.SetCursorPosition(0, 0);

                int gauche = 0;
                int sommet = 0;

                for (int i = 0; i < 300; i++)
                {
                    gauche = rand.Next(0, largeurEcran - 1);
                    sommet = rand.Next(0, hauteurEcran - 1);
                    Console.SetCursorPosition(gauche, sommet);
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.Write("Gi");
                    Console.SetCursorPosition(0,0);
                }

                Console.CursorVisible = false;
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
    }
}

