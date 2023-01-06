using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Addition_Task
{
    class MyClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(0.67);
            arrayList.Add('a');
            arrayList.Add("elem");
            arrayList.Add(new MyClass());

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
