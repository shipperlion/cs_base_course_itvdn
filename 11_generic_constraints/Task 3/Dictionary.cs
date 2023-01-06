using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Dictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int WordCount { get { return keys.Length; } }

        public string this[int index]
        {
            get { return keys[index] + " - " + values[index]; }
        }

        public void AddWord(TKey key, TValue value)
        {
            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[values.Length + 1];

            for(int i = 0; i < keys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempValues[i] = values[i];
            }
            tempKeys[keys.Length] = key;
            tempValues[values.Length] = value;

            keys = tempKeys;
            values = tempValues;
            Console.WriteLine("New word has been added");
        }
    }
}
