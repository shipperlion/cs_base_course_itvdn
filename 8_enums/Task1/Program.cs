using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the color: 0 - Gray, 1 - Blue, 2 - Green, 3 - Red, 4 - Yellow, 5 - Magenta");
            int color = Convert.ToInt32(Console.ReadLine());

            ColorPrinter.Print(str, color);

            Console.ReadKey();
        }
    }
}
