using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the content: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}
