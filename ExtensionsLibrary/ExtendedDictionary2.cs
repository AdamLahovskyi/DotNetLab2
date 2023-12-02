using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public class ExtendedDictionary2<T, U, V> where T : class where U : class where V : class 
    {
        public T key { get; set; }
        public U value1 { get; set; }
        public V value2 { get; set; }

        public ExtendedDictionary2(T key, U value1, V value2)
        {
            this.key = key;
            this.value1 = value1;
            this.value2 = value2;
        }

        public override string ToString()
        {
            return $"key: {key}\nvalue1: {value1}\nvalue2: {value2}";
        }
    }
}
