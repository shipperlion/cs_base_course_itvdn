using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }

    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Search of the string: {0}", str);
        }
    }
}
