using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MyList<T>
    {
        private T[] list;

        public MyList()
        {
            list = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public void Add(T node)
        {
            T[] tempList = new T[list.Length + 1];

            for(int i = 0; i < list.Length; i++)
            {
                tempList[i] = list[i];
            }
            tempList[list.Length] = node;
            list = tempList;
        }

        public int Count { get { return list.Length; } }
    }
}
