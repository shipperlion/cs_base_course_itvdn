using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Car
    {
        protected int year;
        public void Drive() { Console.WriteLine("Driving the car"); }

        abstract public void ShowCar();
        abstract protected void InitializeCar();
    }

    class Volvo: Car
    {
        public Volvo()
        {
            InitializeCar();
        }

        override protected void InitializeCar()
        {
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        override public void ShowCar()
        {
            Console.Write("Type: Volvo");
            Console.Write($"Year: {year}");
        }
    }

    class Renault: Car
    {
        public Renault()
        {
            InitializeCar();
        }

        override protected void InitializeCar()
        {
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        override public void ShowCar()
        {
            Console.Write("Type: Renault");
            Console.Write($"Year: {year}");
        }

    }

    class CarCollection<T> where T: Car
    {
        private T[] parkingLot;

        public CarCollection()
        {
            parkingLot = new T[0];
        }

        public void Add(T car)
        {
            T[] tempLot = new T[parkingLot.Length + 1];

            for(int i = 0; i < parkingLot.Length; i++)
            {
                tempLot[i] = parkingLot[i];
            }
            tempLot[parkingLot.Length] = car;

            parkingLot = tempLot;
            Console.WriteLine("Car added successfuly");
        }

        public int Cars { get { return parkingLot.Length; } }

        public T this[int index]
        {
            get { return parkingLot[index]; }
        }

        public void ShowParkingLot()
        {
            Console.WriteLine("Parking lot:");
            for(int i = 0; i < parkingLot.Length; i++)
            {
                parkingLot[i].ShowCar();
                Console.WriteLine();
            }
        }

        public void ClearParkingLot()
        {
            parkingLot = new T[0];
            Console.WriteLine("Parking lot has been cleared");
        }
    }
}
