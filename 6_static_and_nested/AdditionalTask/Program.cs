using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 + 7 + 9 = {0}", Calculator.Addition(5, 7, 9));

            Console.WriteLine("10 - 3 = {0}", Calculator.Subtraction(10, 3));

            Console.WriteLine("5 * 2 * 3 = {0}", Calculator.Multiplication(5, 2, 3));

            Console.WriteLine("25 / 6 = {0}", Calculator.Division(25, 6));

            Console.ReadKey();
        }
    }
}
