using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Point_3D pointOne = new Point_3D(1, 1, 1);
            Point_3D pointTwo = new Point_3D(2, 2, 2);

            Console.WriteLine("Point one:\n{0}", pointOne.ToString());
            Console.WriteLine("Point two:\n{0}", pointTwo.ToString());

            Point_3D pointThree = pointOne + pointTwo;

            Console.WriteLine("Point three:\n{0}", pointThree.ToString());

            Console.Read();
        }
    }

    struct Point_3D
    {
        double x, y, z;

        public Point_3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get { return x; } }

        public double Y { get { return y; } }

        public double Z { get { return z; } }

        public static Point_3D operator+(Point_3D first, Point_3D second)
        {
            return new Point_3D(first.x + second.x, first.y + second.y, first.z + second.z);
        }

        public override string ToString()
        {
            return $"X: {x}\nY: {y}\nZ: {z}";
        }
    }
}
