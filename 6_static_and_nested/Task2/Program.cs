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
            Book.Note note = new Book.Note();
            note.Text = "AAAAAAAAAAAAAA";
            note.Text = "RRRRRRRRRRRRRRRRRRRRRRR";

            Console.WriteLine(note.Text);

            Console.ReadKey();
        }
    }
}
