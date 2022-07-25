using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter Letter from O, X, Y: ");
                switch (Console.ReadLine().ToUpper())
                {
                    case "Z":
                        Console.Clear();
                        Console.WriteLine("Loading...");
                        DrawZ();
                        break;
                    case "X":
                        Console.Clear();
                        Console.WriteLine("Loading...");
                        DrawX();
                        break;
                    case "Y":
                        Console.Clear();
                        Console.WriteLine("Loading...");
                        DrawY();
                        break;
                    case "O":
                        Console.Clear();
                        Console.WriteLine("Loading...");
                        DrawO();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        private static void DrawZ()
        {
            Console.WriteLine("Enter a Non Negative Odd Number ex 3, 5, 7: ");
            var cnt = int.Parse(Console.ReadLine());

            //check if cnt is non negative and odd number
            if (cnt < 0 || (cnt % 2 == 0))
            {
                Console.WriteLine("Number input is negative or even kindly input another number");
                DrawZ();
            }

            int row, column;
            for (row = 0; row <= cnt; row++)
            {
                for (column = 0; column <= cnt; column++)
                {
                    if (((row == 0 || row == cnt) && column >= 0 && column <= cnt) || row + column == cnt)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }

        private static void DrawX()
        {
            Console.WriteLine("Enter a Non Negative Odd Number ex 3, 5, 7: ");
            var cnt = int.Parse(Console.ReadLine());

            //check if cnt is non negative and odd number
            if (cnt < 0 || (cnt % 2 == 0))
            {
                Console.WriteLine("Number input is negative or even kindly input another number");
                DrawX();
            }

            int row, column;
            for (row = 0; row < cnt; row++)
            {
                for (column = 0; column < cnt; column++)
                {
                    if (row == column || row + column == cnt - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
    
            Console.Read();
        }

        private static void DrawY()
        {
            Console.WriteLine("Enter a Non Negative Odd Number ex 3, 5, 7: ");
            var cnt = int.Parse(Console.ReadLine());

            //check if cnt is non negative and odd number
            if (cnt < 0 || (cnt % 2 == 0))
            {
                Console.WriteLine("Number input is negative or even kindly input another number");
                DrawY();
            }

            int row, column;
            for (row = 0; row <= cnt; row++)
            {
                for (column = 0; column <= cnt; column++)
                {
                    if (((column == 0 || column == cnt) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.Read();
        }


        private static void DrawO()
        {
            Console.WriteLine("Enter a Non Negative Odd Number ex 3, 5, 7: ");
            var cnt = int.Parse(Console.ReadLine());

            //check if cnt is non negative and odd number
            if (cnt < 0 || (cnt % 2 == 0))
            {
                Console.WriteLine("Number input is negative or even kindly input another number");
                DrawO();
            }

            int row, column;
            for (row = 0; row <= cnt; row++)
            {
                for (column = 0; column <= cnt; column++)
                {
                    if (((column == 0 || column == (cnt-1)) && row != 0 && row != cnt) || ((row == 0 || row == cnt) && column > 0 && column < (cnt - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }

    }
}
