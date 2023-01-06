using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate double MyDelegate1(params MyDelegate2[] arr);

    public delegate int MyDelegate2();
    class Program
    {
        public static double Delegate2(params MyDelegate2[] arr)
        {
            int sum = 0;

            Console.Write("(");
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Invoke();
                Console.Write(arr[i].Invoke());
                if (i != arr.Length - 1)
                    Console.Write(" + ");
            }
            Console.Write($") / {arr.Length} = {sum / arr.Length}");
            return sum / arr.Length;
        }

        public static int Delegate1()
        {
            return new Random().Next(0, 50);
        }

        static void Main(string[] args)
        {
            MyDelegate2 random1 = new MyDelegate2(Delegate1);
            MyDelegate2 random2 = new MyDelegate2(Delegate1);
            MyDelegate2 random3 = new MyDelegate2(Delegate1);

            MyDelegate1 average = new MyDelegate1(Delegate2);

            average(random1, random2, random3);

            Console.ReadLine();
        }
    }
}
