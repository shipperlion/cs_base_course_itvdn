using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    class Employee
    {
        readonly string name, surname;
        int expirience;
        string post;

        public int Expirience { get { return expirience; } set { expirience = value; } }
        public string Post { get { return post; } set { post = value; } }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        private double CountSalary()
        {
            double salary;
            switch (expirience)
            {
                case 0:
                    salary = 500;
                    break;
                case 1:
                    salary = 750;
                    break;
                case 2:
                    salary = 1000;
                    break;
                case 5:
                    salary = 2500;
                    break;
                default:
                    salary = 500;
                    break;
            }

            switch (post)
            {
                case "manager":
                    salary *= 2;
                    break;
                case "secretary":
                    salary *= 1.5;
                    break;
                case "developer":
                    salary *= 1.75;
                    break;
                case "cleaner":
                    salary *= 0.75;
                    break;
            }
            return salary;
        }

        public void ShowEmployee()
        {
            Console.WriteLine("Name and Surname: {0} {1}", name, surname);
            Console.WriteLine("Post: {0}", post);
            double salary = CountSalary();
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Tax: {0}", salary * 0.13);
        }
    }
}
