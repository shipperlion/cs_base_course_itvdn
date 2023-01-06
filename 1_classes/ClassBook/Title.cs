using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    class Title
    {
        private string title;

        public Title(string title) { this.title = title; }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Title: {title}");
        }
    }
}
