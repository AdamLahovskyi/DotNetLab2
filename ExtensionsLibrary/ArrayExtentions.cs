using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLibrary
{
    public static class ArrayExtentions
    {
        public static int CountValueOccurrences<T>(this T[] array, T objct)
        {
            int counter = 0;
            foreach (T item in array)
            {
                string item2 = item.ToString();
                string objct2 = objct.ToString();
                if (item2 == objct2)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static T[] ReturnUniqueArray<T>(this T[] array)
        {
            HashSet<T> set = new HashSet<T>(array);
            T[] result = set.ToArray();
            return result;
        }
    }
}
