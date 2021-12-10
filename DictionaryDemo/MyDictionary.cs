using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _key;
        TKey[] _tempKeyArray;
        TValue[] _value;
        TValue[] _tempValueArray;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            // Key ekleme islemi
            _tempKeyArray = _key;
            _key = new TKey[_key.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _key[i] = _tempKeyArray[i];
            }
            _key[_key.Length - 1] = key;


            // Value ekleme islemi
            _tempValueArray = _value;
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _value[i] = _tempValueArray[i];
            }
            _value[_value.Length - 1] = value;

            Console.WriteLine("Plaka Kodu: " + key + " Sehir: " + value);
        }


    }
}
