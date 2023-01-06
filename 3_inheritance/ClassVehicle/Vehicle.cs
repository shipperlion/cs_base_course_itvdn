using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVehicle
{
    class Vehicle
    {
        protected double coordinateX, coordinateY, coordinateZ;
        double price, speed, issueYear;

        public Vehicle(double coordinateX, double coordinateY, double coordinateZ, double price, double speed, double issueYear)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.coordinateZ = coordinateZ;
            this.price = price;
            this.speed = speed;
            this.issueYear = issueYear;
        }

        virtual public void ShowVehicle()
        {
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Year of issue: {issueYear}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"X: {coordinateX}");
            Console.WriteLine($"Y: {coordinateY}");
            Console.WriteLine($"Z: {coordinateZ}");
        }
    }

    class Car: Vehicle
    {
        public Car(double coordinateX, double coordinateY, double coordinateZ, double price, double speed, double issueYear) : base(coordinateX, coordinateY, coordinateZ, price, speed, issueYear) { }

        public override void ShowVehicle()
        {
            Console.WriteLine("Vehicle type: Car");
            base.ShowVehicle();
        }
    }

    class Plane: Vehicle
    {
        double height, passangersNumber;

        public Plane(double coordinateX, double coordinateY, double coordinateZ, double price, double speed, double issueYear, double height, double passangersNumber): base(coordinateX, coordinateY, coordinateZ, price, speed, issueYear)
        {
            this.height = height;
            this.passangersNumber = passangersNumber;
        }

        public override void ShowVehicle()
        {
            Console.WriteLine("Vehicle type: Plane");
            base.ShowVehicle();
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Passengers number: {passangersNumber}");
        }
    }

    class Ship: Vehicle
    {
        double homePort, passangersNumber;

        public Ship(double coordinateX, double coordinateY, double coordinateZ, double price, double speed, double issueYear, double homePort, double passangersNumber) : base(coordinateX, coordinateY, coordinateZ, price, speed, issueYear)
        {
            this.homePort = homePort;
            this.passangersNumber = passangersNumber;
        }

        public override void ShowVehicle()
        {
            Console.WriteLine("Vehicle type: Ship");
            base.ShowVehicle();
            Console.WriteLine($"Height: {homePort}");
            Console.WriteLine($"Passengers number: {passangersNumber}");
        }
    }
}
