using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPointAndFigure
{
    class Figure
    {
        private Point[] figure;

        public Figure(Point point1, Point point2, Point point3)
        {
            figure = new Point[3];
            figure[0] = point1;
            figure[1] = point2;
            figure[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            figure = new Point[4];
            figure[0] = point1;
            figure[1] = point2;
            figure[2] = point3;
            figure[3] = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            figure = new Point[5];
            figure[0] = point1;
            figure[1] = point2;
            figure[2] = point3;
            figure[3] = point4;
            figure[4] = point5;
        }

        private double LengthSide(Point point1, Point point2)
        {
            double lengthSide = Math.Sqrt(Math.Pow((point2.CoordinateX - point1.CoordinateX), 2) + Math.Pow((point2.CoordinateY - point1.CoordinateY), 2));
            return lengthSide;
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for(int i = 0; i < figure.Length - 1; i++)
            {
                perimeter += LengthSide(figure[i], figure[i + 1]) * 2;
            }

            Console.WriteLine($"Perimeter: {perimeter}");
            string figureType;

            switch (figure.Length)
            {
                case 3:
                    figureType = "Triangle";
                    break;
                case 4:
                    figureType = "Tetragon";
                    break;
                case 5:
                    figureType = "Pentagon";
                    break;
                default:
                    figureType = "Undefined figure";
                    break;
            }

            Console.WriteLine($"Type of the figure: {figureType}");
        }
    }
}
