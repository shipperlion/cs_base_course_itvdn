using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            double rectangleArea = side1 * side2;
            return rectangleArea;
        }

        private double PerimeterCalculator()
        {
            double rectanglePerimeter = (side1 + side2) * 2;
            return rectanglePerimeter;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side 1: ");
            double side1;
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2;
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle abcd = new Rectangle(side1, side2);
            double rectanglePerimeter = abcd.Perimeter;
            double rectangleArea = abcd.Area;

            Console.WriteLine($"Rectangle area: {rectangleArea}");
            Console.WriteLine($"Rectangle perimeter: {rectanglePerimeter}");

            Console.ReadLine();
        }
    }
}
