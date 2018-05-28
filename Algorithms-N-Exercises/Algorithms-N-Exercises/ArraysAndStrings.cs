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

        // Check Permutation
        // O(n)
        public static bool CheckPermutation(String str1, String str2)
        {
            //Edge conditions
            if (str1 == null || str2 == null)
            {
                return false;
            }
            if(str1 == String.Empty && str2 == String.Empty)
            {
                return true;
            }
            if (str1 == String.Empty || str2 == String.Empty)
            {
                return false;
            }
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] mem = new int[256];
            //Fill mem with chars from first string
            for(int i = 0; i < str1.Length; i++)
            {
                mem[str1[i]]++;
            }

            //Remove from mem chars, that in str2
            for (int i = 0; i < str2.Length; i++)
            {
                if(mem[str2[i]]-- == 0)
                {
                    return false;
                }
            }

            //Check every char in mem == 0
            for (int i = 0; i < mem.Length; i++)
            {
                if(mem[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
