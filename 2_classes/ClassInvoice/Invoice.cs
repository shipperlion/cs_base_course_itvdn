using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInvoice
{
    class Invoice
    {
        readonly string customer, provider;
        readonly int account;
        
        public string Article { get; set; } 
        public int Quantity { get; set; }

        public Invoice(string customer, string provider, int account)
        {
            this.customer = customer;
            this.provider = provider;
            this.account = account;
        }

        public double CostCalculator(bool needNDS)
        {
            double cost;
            switch (Article)
            {
                case "laptop":
                    cost = 500;
                    break;
                case "PC":
                    cost = 1000;
                    break;
                case "MP3-player":
                    cost = 100;
                    break;
                default:
                    cost = 0;
                    Console.WriteLine("Undefined article");
                    break;
            }
            if (needNDS)
            {
                cost = cost * 7 / 6;
            }
            return cost * Quantity;
        }

        public void ShowInvoice()
        {
            Console.WriteLine("Customer: {0}\nProvider: {1}\nAccount: {2}", customer, provider, account);
            Console.WriteLine("Article: {0}\nQuantity: {1}", Article, Quantity);
            Console.WriteLine("Cost with NDS: {0}\nCost without NDS: {1}", CostCalculator(true), CostCalculator(false));
        }
    }
}
