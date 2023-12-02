using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public class ExtendedDictionary<T, U, V> : IEnumerator, IEnumerable  where T:class where U: class where V: class
    {
        private Dictionary<T, U> _dictionary1;
        private Dictionary<T, V> _dictionary2;
        private int position = -1;

        public int Count 
        {
            get { return _dictionary1.Count; }
        }

        public ExtendedDictionary()
        {
            _dictionary1 = new Dictionary<T, U>();
            _dictionary2 = new Dictionary<T, V>();
        }

        public void AddElements(T key, U val1, V val2) 
        {
            _dictionary1.Add(key, val1);
            _dictionary2.Add(key, val2);
        }

        public void RemoveElemetsByKey(T key)
        {
            _dictionary1.Remove(key);
            _dictionary2.Remove(key);
        }

        public bool CheckIfDictContainsKey(T key)
        {
            return _dictionary1.ContainsKey(key) && _dictionary2.ContainsKey(key);
        }

        public bool CheckKeyContainsValue(U val1, V val2) 
        {
            T? keyValue1 = _dictionary1.FirstOrDefault(vl1 => vl1.Value == val1).Key;
            T? keyValue2 = _dictionary2.FirstOrDefault(vl2 => vl2.Value == val2).Key;
            if(keyValue1 == keyValue2)
            {
                return true;
            }
            if(keyValue1 == null && keyValue2 == null || keyValue1 == null | keyValue2 == null)
            {
                return false;
            }
            return false;
        }

        public ExtendedDictionaryValues<U, V> this[T key]
        {
            get
            {
                return new ExtendedDictionaryValues<U, V>(_dictionary1[key], _dictionary2[key]);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach(T key in _dictionary1.Keys)
            {
                str.Append($"key: {key}\nvalue1: {_dictionary1[key]}\nvalue2: {_dictionary2[key]}\n");
            }
            return str.ToString();
        }
        public object Current
        {
            get
            {
                try
                {
                    KeyValuePair<T, U> keyValue1 = _dictionary1.ElementAt(position);
                    KeyValuePair<T, V> keyValue2 = _dictionary2.ElementAt(position);
                    return new ExtendedDictionary2<T, U, V>(keyValue1.Key, keyValue1.Value, keyValue2.Value);

                }catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _dictionary1.Count);
        }

        public void Reset() 
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

    }
}
