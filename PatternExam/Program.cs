﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PatternBuild;

namespace MainMenu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            while (true)
            {
                Options options = new Options();
                Console.Clear();
                Console.WriteLine("Enter Letter from O, X, Y Or Z: ");
                Console.WriteLine("Press ESC to exit");
                var input = Console.ReadLine().ToUpper();
                if (input == "" || input == " " || input == null)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    MainMenu();
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
                    MainMenu();
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
