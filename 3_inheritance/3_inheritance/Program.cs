using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcellentPupil rose = new ExcellentPupil();
            GoodPupil john = new GoodPupil();
            GoodPupil jade = new GoodPupil();
            BadPupil dave = new BadPupil();

            Classroom classroom = new Classroom(rose, john, jade, dave);
            classroom.ShowClass();
            Console.ReadKey();
        }
    }
}
