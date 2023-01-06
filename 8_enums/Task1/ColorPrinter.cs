using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class ColorPrinter
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.WriteLine("Unidentified color");
                    break;
            }
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private enum Colors
        {
            Gray = 0,
            Blue = 1,
            Green = 2,
            Red = 3,
            Yellow = 4,
            Magenta = 5
        }
    }
}
