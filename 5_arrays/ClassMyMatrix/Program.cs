using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix();
            matrix.Print();
            matrix.PrintDerivative();

            matrix.IncreaseRank();
            matrix.Print();

            matrix.DecreaseRank();
            matrix.Print();

            Console.ReadKey();
        }
    }
}
