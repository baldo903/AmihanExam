using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuild
{
    public class Patterns
    {
        public static void Main(string[] args)
        {

        }

        public static void DrawZ(int cnt)
        {
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
        }

        public static void DrawX(int cnt)
        {
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
        }

        public static void DrawY(int cnt)
        {
            int row, column;
            for (row = 0; row < cnt; row++)
            {
                for (column = 0; column < cnt; column++)
                {
                    if ((row == column || row + column == cnt - 1) && row < ((cnt/2)+1) || (column == (cnt/2) && row >= ((cnt / 2) + 1)))
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
        }


        public static void DrawO(int cnt)
        {
            int row, column;
            for (row = 0; row <= cnt; row++)
            {
                for (column = 0; column <= cnt; column++)
                {
                    if (((column == 0 || column == (cnt - 1)) && row != 0 && row != cnt) || ((row == 0 || row == cnt) && column > 0 && column < (cnt - 1)))
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
        }

    }
}
