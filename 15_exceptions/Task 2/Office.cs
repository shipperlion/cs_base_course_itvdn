using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Office
    {
        private Worker[] office = null;
        
        public Office()
        {
            office = new Worker[0];
        }

        public Office(int count)
        {
            office = new Worker[count];
        }

        public Office(Worker[] _office)
        {
            office = new Worker[_office.Length];
            for(int i = 0; i < office.Length; i++)
            {
                office[i] = _office[i];
            }
        }

        public int Count { get { return office.Length; } }

        private void SortWorkers()
        {
            
        }
    }
}
