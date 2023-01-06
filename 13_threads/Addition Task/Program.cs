using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Task
{
    class Program
    {
        static int depth;

        static public void Recursion()
        {
            Console.WriteLine("{0}  say  \"Hello!\"", Thread.CurrentThread.Name);
            //Thread.Sleep(100);
            Thread thread = new Thread(Recursion);
            depth++;
            thread.Name = "Thread " + depth;
            thread.Start();
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(Recursion) { Name = "Thread " + depth };
            thread.Start();
        }
    }
}
