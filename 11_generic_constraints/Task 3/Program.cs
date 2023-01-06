using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.AddWord("one", "один");
            dic.AddWord("two", "два");
            dic.AddWord("three", "три");
            dic.AddWord("four", "четыре");

            Console.WriteLine($"Number of words in the dictionary: {dic.WordCount}");
            for(int i = 0; i < dic.WordCount; i++)
            {
                Console.WriteLine(dic[i]);
            }

            Console.ReadLine();
        }
    }
}
