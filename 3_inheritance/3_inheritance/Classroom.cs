using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_inheritance
{
    class Classroom
    {
        readonly Pupil[] classroom;

        public Classroom(params Pupil[] classroom)
        {
            this.classroom = classroom;
        }

        public void ShowClass()
        {
            for(int i = 0; i < classroom.Length; i++)
            {
                Console.WriteLine($"Student {i+1}:");
                classroom[i].Study();
                classroom[i].Read();
                classroom[i].Write();
                classroom[i].Relax();
                Console.WriteLine("\n");
            }
        }
    }
}
