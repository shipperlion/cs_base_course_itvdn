using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MyList<T>
    {
        T[] array = null;
        int position = -1;

        public int Elements { get { return array.Length; } }

        public MyList() { array = new T[0]; }

        public void Add(T element)
        {
            T[] newArray = new T[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[array.Length] = element;
            array = newArray;
        }

        public T this[int index] { get { return array[index]; } }

        public void Reset() { position = -1; }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
