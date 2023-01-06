using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocumentWorker
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() { Console.WriteLine("Document has been edited"); }
        public override void SaveDocument() { Console.WriteLine("Document has been saved in the old format. Buy the Expert edition to save in other extensions"); }
    }
}
