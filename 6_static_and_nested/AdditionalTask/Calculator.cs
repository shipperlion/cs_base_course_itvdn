using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    static class Calculator
    {
        public static int Addition(params int[] args)
        {
            int sum = 0;
            for(int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }

        public static int Multiplication(params int[] args)
        {
            int mult = 1;
            for(int i = 0; i < args.Length; i++)
            {
                mult *= args[i];
            }
            return mult;
        }

        public static int Subtraction(int minuend, int subtrahend)
        {
            int difference = minuend - subtrahend;
            return difference;
        }

        public static double Division(int dividend, int divisor)
        {
            if(divisor != 0)
            {
                double quotient = (double)dividend / divisor;
                return quotient;
            }
            else
            {
                return double.NaN;
            }
        }
    }
}
