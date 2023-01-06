using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < keys.Length)
                    return keys[index] + " - " + values[index];
                return "Попытка обращения за пределы массива.";
            }
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempValues[i] = values[i];
            }

            tempKeys[keys.Length] = key;
            tempValues[values.Length] = value;
            keys = tempKeys;
            values = tempValues;
        }

        public int Count { get { return keys.Length; } }
    }
}
