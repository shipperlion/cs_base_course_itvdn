using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the key: ");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                case "exp":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    doc = new DocumentWorker();
                    Console.WriteLine("Not valid key");
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
