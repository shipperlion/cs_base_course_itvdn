using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler doc = new DOCHandler();
            TXTHandler txt = new TXTHandler();
            XMLHandler xml = new XMLHandler();

            doc.Create();
            doc.Open();
            doc.Change();
            doc.Save();

            txt.Create();
            txt.Open();
            txt.Change();
            txt.Save();

            xml.Create();
            xml.Open();
            xml.Change();
            xml.Save();

            Console.ReadKey();
        }
    }
}
