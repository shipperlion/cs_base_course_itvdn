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
            MyClass myclass = new MyClass();
            MyStruct mystruct = new MyStruct();

            Console.WriteLine("myclass.change = {0}", myclass.change);
            Console.WriteLine("mystruct.change = {0}", mystruct.change);

            ClassTaker(myclass);
            StructTaker(mystruct);

            Console.WriteLine("myclass.change = {0}", myclass.change);
            Console.WriteLine("mystruct.change = {0}", mystruct.change);

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }
    }
}
