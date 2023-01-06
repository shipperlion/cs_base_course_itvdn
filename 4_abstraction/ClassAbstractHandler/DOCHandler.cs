using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractHandler
{
    class DOCHandler: AbstractHandler
    {
        public override void Create() { Console.WriteLine("Create .doc file"); }
        public override void Open() { Console.WriteLine("Open .doc file"); }
        public override void Change() { Console.WriteLine("Change .doc file"); }
        public override void Save() { Console.WriteLine("Save .doc file"); }
    }
}
