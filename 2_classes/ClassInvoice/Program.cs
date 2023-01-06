using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice tovar = new Invoice("John", "Samsung", 12345);
            tovar.Article = "laptop";
            tovar.Quantity = 3;

            tovar.ShowInvoice();

            Console.ReadKey();
        }
    }
}
