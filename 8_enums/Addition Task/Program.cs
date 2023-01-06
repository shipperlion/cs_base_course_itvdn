using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime bday;
            TimeSpan wait;

            Console.Write("Enter you date of birth: ");

            bday = Convert.ToDateTime(Console.ReadLine());

            DateTime thisYear = new DateTime(now.Year, bday.Month, bday.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, bday.Month, bday.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }

            Console.WriteLine("Days til the next birthday: {0}", wait.Days);

            // Delay.
            Console.ReadKey();
        }
    }
}
