using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractHandler
{
    class XMLHandler: AbstractHandler
    {
        public override void Create() { Console.WriteLine("Create .xml file"); }
        public override void Open() { Console.WriteLine("Open .xml file"); }
        public override void Change() { Console.WriteLine("Change .xml file"); }
        public override void Save() { Console.WriteLine("Save .xml file"); }
    }
}
