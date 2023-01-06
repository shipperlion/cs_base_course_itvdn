using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate average = delegate (int x, int y, int z) { return (x + y + z) / 3; };

            Console.Write("First number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({first} + {second} + {third}) / 3 = {average(first, second, third)}");

            Console.ReadLine();
        }

        public delegate double MyDelegate(int a, int b, int c);
    }
}
