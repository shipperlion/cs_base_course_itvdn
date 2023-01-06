using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.Write("Array: ");
            arr.FillArray();
            arr.PrintArray();

            arr.SortAscending();
            Console.Write("\nSorted array: ");
            arr.PrintArray();

            Console.ReadKey();
        }
    }
}
