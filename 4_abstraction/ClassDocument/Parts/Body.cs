using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocument
{
    class Body: Part
    {
    public override string Content
    {
        get
        {
            if (content != null)
                return content;
            else
                return "No body";
        }
        set { content = value; }
    }

    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
}
