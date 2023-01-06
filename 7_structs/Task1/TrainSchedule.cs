using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TrainSchedule
    {
        Train[] schedule;

        public TrainSchedule()
        {
            InitializeSchedule();
            FillSchedule();
        }

        public TrainSchedule(int numberOfTrains)
        {
            schedule = new Train[numberOfTrains];

            FillSchedule();
        }

        private void InitializeSchedule()
        {
            Console.Write("Enter the number of trains: ");
            int numberOfTrains = Convert.ToInt32(Console.ReadLine());
            schedule = new Train[numberOfTrains];
        }

        private void FillSchedule()
        {
            for (int i = 0; i < schedule.Length; i++)
            {
                Console.Write("Enter the train number: ");
                schedule[i].TrainNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the destination: ");
                schedule[i].Destination = Console.ReadLine();

                Console.Write("Enter the departure time: ");
                schedule[i].DepartureTime = Console.ReadLine();

                Console.WriteLine();
            }
        }

        public void SortByNumber()
        {
            for (int i = 0; i < schedule.Length - 1; i++)
            {
                for (int j = 0; j < schedule.Length - i - 1; j++)
                {
                    if (schedule[j].TrainNumber > schedule[j + 1].TrainNumber)
                    {
                        Train temp = schedule[j];
                        schedule[j] = schedule[j + 1];
                        schedule[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintSchedule()
        {
            Console.WriteLine("Schedule:");
            for (int i = 0; i < schedule.Length; i++)
            {
                schedule[i].PrintTrain();
                Console.WriteLine("=========================");
            }
        }

        public void FindByNumber(int number)
        {
            bool trainFound = false;
            for (int i = 0; i < schedule.Length; i++)
            {
                if (schedule[i].TrainNumber == number)
                {
                    Console.WriteLine("Train found:");
                    schedule[i].PrintTrain();
                    trainFound = true;
                }
                else
                    continue;
            }

            if (!trainFound)
            {
                Console.WriteLine("There is no such train in the schedule");
            }
        }
    }

    struct Train
    {
        private string destination;
        private int trainNumber;
        private string departureTime;

        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public void PrintTrain()
        {
            Console.WriteLine($"Train number: {trainNumber}");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Departure time: {departureTime}");
        }
    }
}
