using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocument
{
    class Footer: Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "No footer";
            }
            set { content = value; }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
