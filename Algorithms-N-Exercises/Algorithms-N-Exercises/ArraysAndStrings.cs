using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public static class ArraysAndStrings
    {
        // IsStringUnique2
        // O(n)
        public static bool IsStringUnique(String str)
        {
            //Edge conditions
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            int[] mem = new int[256];

            for (int i = 0; i < str.Length; i++)
            {
                mem[(int)str[i]]++;
                if (mem[str[i]] > 1)
                {
                    return false;
                }
            }

            return true;
        }

        // IsStringUnique2 without using extra space
        // O(nlogn)
        public static bool IsStringUnique2(String str)
        {
            //Edge conditions
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            var chars = str.ToArray();
            Array.Sort(chars);
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
