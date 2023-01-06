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
            TrainSchedule schedule = new TrainSchedule();

            schedule.SortByNumber();
            schedule.PrintSchedule();

            Console.Write("Enter the number of the train: ");
            int number = Convert.ToInt32(Console.ReadLine());

            schedule.FindByNumber(number);

            Console.ReadKey();
        }
    }
}
