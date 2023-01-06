using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Search of the string: {0}", str);
        }

        public class Note
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }
    }
}
