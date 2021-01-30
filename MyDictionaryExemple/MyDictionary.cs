using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryExemple
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key,T2 value)
        {
            T1[] TempArray = keys;
            T2[] TempArray2 = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < TempArray.Length; i++)
            {
                keys[i] = TempArray[i];
                values[i] = TempArray2[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public T1[] key
        {
            get { return keys; }
        }
        public T2[] value
        {
            get { return values; }
        }
    }
}
