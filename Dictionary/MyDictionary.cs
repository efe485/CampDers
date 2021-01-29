using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] Keys;
        TValue[] Values;

        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] _tempKey = Keys;
            TValue[] _tempValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                Keys[i] = _tempKey[i];
                
            }
            for (int j = 0; j < _tempValue.Length; j++)
            {
                Values[j] = _tempValue[j];
            }

            Values[Values.Length - 1] = value;
            Keys[Keys.Length - 1] = key;

        }
    }
}
