using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPointAndFigure
{
    class Point
    {
        private int coordinateX;
        private int coordinateY;
        private string pointName;

        public int CoordinateX { get { return coordinateX; } }
        public int CoordinateY { get { return coordinateY; } }
        public string PointName { get { return pointName; } }

        public Point(int coordinateX, int coordinateY, string pointName)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.pointName = pointName;
        }
    }
}
