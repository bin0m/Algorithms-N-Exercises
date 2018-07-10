using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (str1 == String.Empty && str2 == String.Empty)
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
            for (int i = 0; i < str1.Length; i++)
            {
                mem[str1[i]]++;
            }

            //Remove from mem chars, that in str2
            for (int i = 0; i < str2.Length; i++)
            {
                if (mem[str2[i]]-- == 0)
                {
                    return false;
                }
            }

            //Check every char in mem == 0
            for (int i = 0; i < mem.Length; i++)
            {
                if (mem[i] != 0)
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
                if (abc[i] > 0)
                {
                    if (abc[i] % 2 == 1)
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
            if (str1 == null || str2 == null)
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
                if (dict.ContainsKey(str2[i]))
                {
                    if (dict[str2[i]] == 1)
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

        // String is prime, when it does not contain repeating sequences
        // O(n^3)
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

        // RotateMatrix
        // Time complexity: O(n^2)
        // Space complexity: O(1) - no additional memory was used
        public static bool RotateMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.GetUpperBound(0) != matrix.GetUpperBound(1))
            {
                return false;
            }
            int size = matrix.GetUpperBound(0) + 1;

            for (int line = 0; line < size; line++)
            {
                for (int i = line + 1; i < size - line; i++)
                {
                    int temp = matrix[line, i];
                    matrix[line, i] = matrix[size - i - 1, line];
                    matrix[size - i - 1, line] = matrix[size - line - 1, size - i - 1];
                    matrix[size - line - 1, size - i - 1] = matrix[i, size - line - 1];
                    matrix[i, size - line - 1] = temp;
                }
            }
            return true;
        }

        //helper method to print matrix
        // O(n^2)
        public static string MatrixToString(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                sb.Append('[');
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    sb.Append(matrix[i, j].ToString().PadLeft(2)).Append(',');
                }
                sb.Length--;
                sb.AppendLine("],");
            }
            return sb.ToString();
        }

        public static void ArrayInitializations()
        {
            // 1
            double[] balance = new double[10];
            // 2
            double[] balance2 = { 2340.0, 4523.69, 3421.0 };
            // 3
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            // 4 
            int[] marks2 = new int[] { 99, 98, 92, 97, 95 };
            // 5
            int[] arr2 = { };
        }

        // Can be L (Letter) be written using characters from N (Newspaper) ?
        static public bool CanBeWrittenFrom(string L, string N)
        {
            var dict = new Dictionary<char, int>();
            int charCount = 0;

            // 1. count all the characters we need to find in Dictionary
            foreach (char c in L)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                    charCount++;
                }
            }

            //2. scan N and reduce its count in Dictionary 
            // If all counts in Dictionary are zero at some point, we return true
            foreach (char c in N)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]--;
                    if (dict[c] == 0)
                    {                       
                        charCount--;
                        if(charCount == 0)
                        {
                            return true;
                        }
                    }                   
                }
            }
            return false;
        }

        // returns a list of all unique words in it and their number of occurrences,
        // sorted by the number of occurrences in a descending order
        // O(nlogn) - sort
        public static string[,] WordCountEngine(string document)
        {
            var cleanDoc = StripOutNonAlphabeticalCharacters(document);
            var words = cleanDoc.Split(' ');
            var dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if( word == string.Empty)
                {
                    continue;
                }

                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            var sort = from pair in dict
                       orderby pair.Value descending
                       select pair;
            var answer = new string[dict.Count, 2];
            int index = 0;
            foreach (KeyValuePair<string, int> pair in sort)
            {
                answer[index, 0] = pair.Key;
                answer[index++, 1] = pair.Value.ToString();
            }
            return answer;
        }

        // helper method for WordCountEngine()
        // O(n) 
        private static string StripOutNonAlphabeticalCharacters(string document)
        {
            var sb = new StringBuilder();
            foreach (char c in document)
            {
                if (c == ' ' || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
                else if ((c >= 'A' && c <= 'Z'))
                {
                    sb.Append(char.ToLower(c));
                }
            }
            return sb.ToString();
        }

        //helper method to print matrix
        // O(n^2)
        public static string MatrixToString(string[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                sb.Append('[');
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    sb.Append('"').Append(matrix[i, j].ToString()).Append('"').Append(',');
                }
                sb.Length--;
                sb.Append("],");
            }
            return sb.ToString();
        }
    }
}
