using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        private K[] keys;
        private V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] arrayKey = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < arrayKey.Length; i++)
            {
                keys[i] = arrayKey[i];
            }
            keys[keys.Length - 1] = key;

            V[] arrayValue = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < arrayValue.Length; i++)
            {
                values[i] = arrayValue[i];
            }
            values[values.Length - 1] = value;
        }
        public int Lenght
        {
            get { return keys.Length; }
        }
        public K[] Keys
        {
            get { return keys; }
        }
        public V[] Values
        {
            get { return values; }
        }

    }
}
