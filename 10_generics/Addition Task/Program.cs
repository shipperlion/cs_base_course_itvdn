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
            int i = MyClass<int>.FacrotyMethod();

            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.FacrotyMethod();

            Console.WriteLine(p.GetType().Name);

            Console.ReadKey();
        }
    }
}
