using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            Console.WriteLine("Длина массива = {0}", list.Elements);

            foreach (int item in list)
                Console.Write("{0}  ", item);

            // Delay.
            Console.ReadKey();
        }
    }
}
