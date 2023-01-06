using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocumentWorker
{
    class DocumentWorker
    {
        public void OpenDocument() { Console.WriteLine("Document is open"); }
        virtual public void EditDocument() { Console.WriteLine("Buy the Pro edition to edit"); }
        virtual public void SaveDocument() { Console.WriteLine("Buy the Pro edition to save"); }

    }
}
