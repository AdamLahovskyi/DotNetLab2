using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public class ExtendedDictionaryValues<U, V> where U : class where V : class 
    {
        public U value1 { get; set; }
        public V value2 { get; set; }

        public ExtendedDictionaryValues(U value1, V value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public override string ToString()
        {
            return $"value1: {value1}\nvalue2: {value2}\n";
        }
    }
}
