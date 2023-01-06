using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Volvo car1 = new Volvo();
            Renault car2 = new Renault();
            Volvo car3 = new Volvo();
            Renault car4 = new Renault();

            CarCollection<Volvo> lot1 = new CarCollection<Volvo>();
            lot1.Add(car1);
            lot1.Add(car3);

            lot1.ShowParkingLot();

            lot1.ClearParkingLot();

            CarCollection<Renault> lot2 = new CarCollection<Renault>();
            lot2.Add(car2);
            lot2.Add(car4);

            lot2.ShowParkingLot();

            lot2.ClearParkingLot();


            Console.Read();
        }
    }
}
