using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hours of the work: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant a = new Accauntant();

            if (a.AskForBonus(Post.Cleaner, hours))
            {
                Console.WriteLine("Дать премию");
            }
            else
            {
                Console.WriteLine("Не выдавать премию");
            }

            //Delay.
            Console.ReadKey();
        }
    }
}
