using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Jones");
            employee.Expirience = 5;
            employee.Post = "manager";
            employee.ShowEmployee();

            Console.ReadKey();
        }
    }
}
