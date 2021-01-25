using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Key, Value>
    {
        Key[] keys; 
        Value[] values; 

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempArrayK = keys; 
            keys = new Key[keys.Length + 1];

            Value[] tempArrayV = values;
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
            }
            keys[keys.Length - 1] = key; 

            for (int i = 0; i < tempArrayV.Length; i++)
            {
                values[i] = tempArrayV[i];
            }
            values[values.Length - 1] = value; 

            Console.WriteLine(key + " " + value + " ");

        }
    }
}