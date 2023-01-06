using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("uah: ");
            double uah = Convert.ToDouble(Console.ReadLine());

            Converter conv = new Converter(36.57, 36.14, 0.62);
            Console.WriteLine("usd: {0}", conv.ToUsd(uah));
            Console.WriteLine("eur: {0}", conv.ToEur(uah));
            Console.WriteLine("rub: {0}", conv.ToRub(uah));

            Console.Write("\nCurrency type: ");
            string currencyType = Console.ReadLine();
            Console.Write("Sum: ");
            double currency = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("uah: {0}", conv.ToUah(currency, currencyType));

            Console.ReadKey();
        }
    }
}
