using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block first = new Block(1, 1, 1, 1);
            Block second = new Block(2, 2, 2, 2);
            Block third = new Block(1, 1, 1, 1);

            Console.WriteLine("First block:\n{0}", first.ToString());
            Console.WriteLine("\nSecond block:\n{0}", second.ToString());
            Console.WriteLine("\nThird block:\n{0}", third.ToString());

            Console.WriteLine(first.Equals(second));
            Console.WriteLine(first.Equals(third));

            Console.ReadLine();
        }
    }

    class Block
    {
        double firstSide, secondSide, thirdSide, fourthSide;

        public Block()
        {
            firstSide = secondSide = thirdSide = fourthSide = 1;
        }

        public Block(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.fourthSide = fourthSide;
        }

        public double FirstSide { get { return firstSide; } }

        public double SecondSide { get { return secondSide; } }

        public double ThirdSide { get { return thirdSide; } }

        public double FourthSide { get { return fourthSide; } }

        public override string ToString()
        {
            return $"First side: {firstSide}\nSecond side: {secondSide}\nThird side: {thirdSide}\nFourth side: {fourthSide}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block p = (Block)obj;
            return (firstSide == p.firstSide) && (secondSide == p.secondSide) && (thirdSide == p.thirdSide) && (fourthSide == p.fourthSide);
        }
    }
}
