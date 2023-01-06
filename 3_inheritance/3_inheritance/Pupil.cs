using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_inheritance
{
    class Pupil
    {
        virtual public void Study() { Console.WriteLine("Studying"); }
        virtual public void Read() { Console.WriteLine("Reading"); }
        virtual public void Write() { Console.WriteLine("Writing"); }
        virtual public void Relax() { Console.WriteLine("Relaxing"); }
    }

    class ExcellentPupil: Pupil
    {
        public override void Study() { Console.WriteLine("Studying hard"); }
        public override void Read() { Console.WriteLine("Reading carefully"); }
        public override void Write() { Console.WriteLine("Writing neatly"); }
        public override void Relax() { Console.WriteLine("Barely relaxing"); }
    }
    class GoodPupil: Pupil
    {
        public override void Study() { Console.WriteLine("Studying well"); }
        public override void Read() { base.Read(); }
        public override void Write() { base.Write(); }
        public override void Relax() { base.Relax(); }
    }

    class BadPupil: Pupil
    {
        public override void Study() { Console.WriteLine("Studying poorly"); }
        public override void Read() { Console.WriteLine("Not reading"); }
        public override void Write() { Console.WriteLine("Not writing"); }
        public override void Relax() { Console.WriteLine("Relaxing fully"); }
    }
}
