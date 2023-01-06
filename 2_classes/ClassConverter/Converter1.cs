using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConverter
{
    class Converter
    {
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ToUsd(double uah)
        {
            return uah / usd;
        }
        public double ToEur(double uah)
        {
            return uah / eur;
        }
        public double ToRub(double uah)
        {
            return uah / rub;
        }

        public double ToUah(double currency, string currencyType)
        {
            double uah;
            switch (currencyType)
            {
                case "usd":
                    uah = currency * usd;
                    break;
                case "eur":
                    uah = currency * eur;
                    break;
                case "rub":
                    uah = currency * rub;
                    break;
                default:
                    Console.WriteLine("Undefined currency");
                    uah = -1;
                    break;
            }
            return uah;
        }

    }
}
