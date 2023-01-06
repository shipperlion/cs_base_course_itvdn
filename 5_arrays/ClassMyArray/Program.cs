using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();

            arr.Print();
            Console.WriteLine("\nThe biggest value: {0}", arr.BiggestValue());
            Console.WriteLine("The smallest value: {0}", arr.SmallestValue());
            Console.WriteLine("Total sum of elements: {0}", arr.TotalSum());
            Console.WriteLine("Arithmetic mean: {0}", arr.ArithmeticMean());
            Console.Write("Odd elements: "); arr.OddElements();

            Console.ReadKey();
        }
    }
}
