using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocument
{
    class Title: Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "No title";
            }
            set { content = value; }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
