using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyArray
{
    class MyArray
    {
        int[] arr = null;

        void InitializeArray()
        {
            Console.Write("Enter the number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
        }

        public MyArray()
        {
            InitializeArray();
            FillArray();
        }

        public MyArray(int size)
        {
            arr = new int[size];
            FillArray();
        }

        void FillArray()
        {
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
        }

        public int BiggestValue()
        {
            int biggestValue = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > biggestValue)
                {
                    biggestValue = arr[i];
                }
            }
            return biggestValue;
        }

        public int SmallestValue()
        {
            int smallestValue = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestValue)
                {
                    smallestValue = arr[i];
                }
            }
            return smallestValue;
        }

        public int TotalSum()
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public double ArithmeticMean()
        {
            return (double)TotalSum() / arr.Length;
        }

        public void OddElements()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }

        public void Print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
