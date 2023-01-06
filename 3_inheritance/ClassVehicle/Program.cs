using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 0, 0, 100, 0, 2015);
            Plane plane = new Plane(5, 6, 200, 1000, 500, 2018, 3, 100);
            Ship ship = new Ship(9, 523, 7, 1500, 100, 2013, 5, 500);

            car.ShowVehicle();
            plane.ShowVehicle();
            ship.ShowVehicle();

            Console.ReadKey();
        }
    }
}
