using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct Worker
    {
        private string name;
        private string post;
        private int year;

        public string Name { get { return name; } }

        private void AssignWorker()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Post: ");
            post = Console.ReadLine();

            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowWorker()
        {
            Console.WriteLine($"Name: {name}");

            Console.WriteLine($"Post: {post}");

            Console.WriteLine($"Year: {year}");
        }
    }
}
