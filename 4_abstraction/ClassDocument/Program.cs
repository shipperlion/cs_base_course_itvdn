using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Contract");
            doc.Body = "Body of the contract...";
            doc.Footer = "Footer of the contract";

            doc.Show();

            Console.ReadKey();
        }
    }
}
