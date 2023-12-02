using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLibrary
{
    public static class StringExtentions
    {
        public static string ReverseString(this string str)
        {
            string revers = "";
            for (int i = str.Length - 1; i >= 0; i--)
                revers += str[i];
            return revers;
        }

        public static int CountOccurrences(this string str, char character)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == character)
                    count++;
            }
            return count;
        }
    }
}
