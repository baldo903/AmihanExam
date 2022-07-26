using Model;
using System;
using PatternBuild;
using System.Linq;

namespace MainMenu
{
    public class Menu
    {
        public static void Main()
        {
        }

        public static void StartMenu()
        {
            var isOpen = true;
            while (isOpen)
            {
                Options options = new Options();
                Console.WriteLine("Enter Letter from O, X, Y Or Z: ");
                string[] patternOptions = { "X", "Y", "O", "Z" };
                var input = Console.ReadLine().ToUpper();
                if (input == "" || input == " " || input == null || !patternOptions.Contains(input))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    StartMenu();
                }

                options.Pattern = input;
                Console.Clear();
                Console.WriteLine("Loading...");
                GetCount(options);
            }
        }

        private static void GetCount(Options options)
        {
            Console.WriteLine("Enter a Non Negative Odd Number ex 3, 5, 7: ");
            var cnt = int.Parse(Console.ReadLine());

            //check if cnt is non negative and odd number
            if (cnt < 0 || (cnt % 2 == 0))
            {
                Console.Clear();
                Console.WriteLine("Number input is negative or even kindly input another number");
                GetCount(options);
            }
            options.Count = cnt;

            switch (options.Pattern)
            {
                case "Z":
                    DrawZ(options);
                    break;
                case "X":
                    DrawX(options);
                    break;
                case "Y":
                    DrawY(options);
                    break;
                case "O":
                    DrawO(options);
                    break;
                default:
                    Console.Clear();
                    StartMenu();
                    break;
            }
        }

        private static void DrawZ(Options options)
        {
            Patterns Patterns = new Patterns();
            Patterns.DrawZ(options.Count);
            Console.Read();
        }

        private static void DrawX(Options options)
        {
            Patterns Patterns = new Patterns();
            Patterns.DrawX(options.Count);
            Console.Read();
        }

        private static void DrawY(Options options)
        {
            Patterns Patterns = new Patterns();
            Patterns.DrawY(options.Count);
            Console.Read();
        }

        private static void DrawO(Options options)
        {
            Patterns Patterns = new Patterns();
            Patterns.DrawO(options.Count);
            Console.Read();
        }
    }
}
