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
        // O(n+m)
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

        // IsPalindromePermutation
        // O(n)
        public static bool IsPalindromePermutation(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return true;
            }

            int[] abc = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    abc[str[i] - 'A']++;
                }
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    abc[str[i] - 'a']++;
                }
            }

            bool singleExists = false;

            for (int i = 0; i < abc.Length; i++)
            {
                if(abc[i]> 0)
                {
                    if(abc[i] % 2 == 1)
                    {
                        if (singleExists)
                        {
                            return false;
                        }
                        singleExists = true;
                    }
                }
            }          
            return true;
        }

        // IsOneAway
        // O(n+m)
        public static bool IsOneAway(String str1, String str2)
        {
            //edge conditions
            if(str1 == null || str2 == null)
            {
                return false;
            }

            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (dict.ContainsKey(str1[i]))
                {
                    dict[str1[i]]++;
                }
                else
                {
                    dict[str1[i]] = 1;
                }
            }
            bool wasOneDifference = false;
            for (int i = 0; i < str2.Length; i++)
            {
                if(dict.ContainsKey(str2[i]))
                {
                    if(dict[str2[i]] == 1)
                    {
                        dict.Remove(str2[i]);
                    }
                    else
                    {
                        dict[str2[i]]--;
                    }
                }
                else
                {
                    if (wasOneDifference)
                    {
                        return false;
                    }
                    else
                    {
                        wasOneDifference = true;
                    }
                }
            }

            if (dict.Count > 1)
            {
                return false;
            }

            return true;
        }

        public static bool IsPrime(String str)
        {
            if (str == null || str.Length < 2)
            {
                return true;
            }
            int n = str.Length;
            //check differnt size of substrings from 1 to n/2
            for (int size = 1; size <= n / 2; size++)
            {
                int parts = n / size;
                if (parts * size != n)
                {
                    continue;
                }
                bool partsAreEqual = true;
                // compare every part to first part
                for (int part = 1; part < parts && partsAreEqual; part++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (str[j] != str[j + part * size])
                        {
                            partsAreEqual = false;
                            break;
                        }
                    }
                }
                if (partsAreEqual)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
