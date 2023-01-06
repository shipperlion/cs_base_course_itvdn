using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();
            myAddress.Index = "1143";
            myAddress.Country = "Hungary";
            myAddress.City = "Budapest";
            myAddress.Street = "Ilka";
            myAddress.House = "46";
            myAddress.Apartment = "1/3";

            myAddress.ShowAddress();

            Console.ReadKey();
        }
    }
}
