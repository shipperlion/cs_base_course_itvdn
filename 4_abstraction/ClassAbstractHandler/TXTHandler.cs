using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractHandler
{
    class TXTHandler: AbstractHandler
    {
        public override void Create() { Console.WriteLine("Create .txt file"); }
        public override void Open() { Console.WriteLine("Open .txt file"); }
        public override void Change() { Console.WriteLine("Change .txt file"); }
        public override void Save() { Console.WriteLine("Save .txt file"); }
    }
}
