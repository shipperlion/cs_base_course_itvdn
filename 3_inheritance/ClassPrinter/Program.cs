using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello");

            Printer printUp = print;
            printUp.Print("Hello");

            ColorPrinter print1 = new ColorPrinter(ConsoleColor.Red);
            print1.Print("Hello");

            // Delay.
            Console.ReadKey();
        }
    }
}
