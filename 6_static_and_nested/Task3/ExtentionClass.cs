using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    static class ExtentionClass
    {
        public static void SortAscending(this int[] value)
        {
            for(int i = 0; i < value.Length - 1; i++)
            {
                for(int j = 0;j<value.Length - i - 1; j++)
                {
                    if(value[j] > value[j + 1])
                    {
                        int temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray(this int[] value)
        {
            for(int i = 0; i < value.Length; i++)
            {
                Console.Write($" {value[i]}");
            }
        }

        public static void FillArray(this int[] value)
        {
            Random rand = new Random();
            for(int i = 0; i < value.Length; i++)
            {
                value[i] = rand.Next(0, 25);
            }
        }
    }
}
