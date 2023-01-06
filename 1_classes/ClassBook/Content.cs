using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    class Content
    {
        private string content;

        public Content(string content) { this.content = content; }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Content: {content}");
        }
    }
}
