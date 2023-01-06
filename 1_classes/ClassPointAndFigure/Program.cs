using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPointAndFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(1, 1, "A");
            Point B = new Point(2, 2, "B");
            Point C = new Point(5, 6, "C");
            Point D = new Point(3, 4, "D");

            Figure figure = new Figure(A, B, C, D);
            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
