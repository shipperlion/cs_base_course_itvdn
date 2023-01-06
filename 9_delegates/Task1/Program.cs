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
            Operations Add = (x, y) => { return x + y; };
            Operations Sub = (x, y) => { return x - y; };
            Operations Mul = (x, y) => { return x * y; };
            Operations Div = (x, y) => { return x / y != double.NaN ? x / y : double.NaN; };

            Console.Write("First number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = Add(first, second);
                    break;
                case "-":
                    result = Sub(first, second);
                    break;
                case "*":
                    result = Mul(first, second);
                    break;
                case "/":
                    result = Div(first, second);
                    break;
                default:
                    Console.WriteLine("Undefined operation");
                    break;
            }

            Console.WriteLine($"{first} {operation} {second} = {result}");


            Console.ReadKey();
        }

        public delegate double Operations(double a, double b);
    }
}
