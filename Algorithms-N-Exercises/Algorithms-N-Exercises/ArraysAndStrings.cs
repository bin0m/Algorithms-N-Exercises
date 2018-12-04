﻿using System;
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

            foreach (char c in str)
            {
                mem[c]++;
                if (mem[c] > 1)
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
            foreach (char c in str1)
            {
                mem[c]++;
            }

            //Remove from mem chars, that in str2
            foreach (char c in str2)
            {
                if (mem[c]-- == 0)
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
            foreach (char c in str)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    abc[c - 'A']++;
                }

                if (c >= 'a' && c <= 'z')
                {
                    abc[c - 'a']++;
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
            foreach (char c in str1)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            bool wasOneDifference = false;
            foreach (char c2 in str2)
            {
                if (dict.ContainsKey(c2))
                {
                    if (dict[c2] == 1)
                    {
                        dict.Remove(c2);
                    }
                    else
                    {
                        dict[c2]--;
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


        // A String is called prime if it can't be constructed by concatenating multiple (more than one) equal strings.
        // For example:
        // "abac" is prime, but "xyxy" is not("xyxy" = "xy" + "xy").
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
        public static bool CanBeWrittenFrom(string L, string N)
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
                        if (charCount == 0)
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
        // O(n)
        public static string[,] WordCountEngine(string document)
        {
            var cleanDoc = StripOutNonAlphabeticalCharacters(document);
            var words = cleanDoc.Split(' ');
            var dict = new Dictionary<string, int>();
            var maxCount = 0;
            foreach (string word in words)
            {
                if (word == string.Empty)
                {
                    continue;
                }

                if (dict.ContainsKey(word))
                {
                    var count = ++dict[word];
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            var bucketsByCount = new List<string>[maxCount + 1];
            foreach (var pair in dict)
            {
                if (bucketsByCount[pair.Value] == null)
                {
                    bucketsByCount[pair.Value] = new List<string>
                    {
                        pair.Key
                    };
                }
                else
                {
                    bucketsByCount[pair.Value].Add(pair.Key);
                }
            }

            var answer = new string[dict.Count, 2];
            int index = 0;
            for (int i = bucketsByCount.Length - 1; i >= 0; i--)
            {
                if (bucketsByCount[i] != null)
                {
                    foreach (var word in bucketsByCount[i])
                    {
                        answer[index, 0] = word;
                        answer[index++, 1] = i.ToString();
                    }
                }

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
                    sb.Append('"').Append(matrix[i, j]).Append('"').Append(',');
                }

                sb.Length--;
                sb.Append("],");
            }

            return sb.ToString();
        }


        // helper method for MeetingPlanner
        private static int[] FindCommonSlot(int startA, int endA, int startB, int endB)
        {
            int commonStart = Math.Max(startA, startB);
            int commonEnd = Math.Min(endA, endB);
            if (commonEnd <= commonStart)
            {
                return new int[0];
            }

            return new int[2] { commonStart, commonEnd };
        }

        // returns the earliest time slot that works for both of them and is of duration dur
        // time: O(n+m)
        // space: O(1)
        public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            //edge cases
            if (slotsA == null || slotsB == null || dur <= 0)
            {
                return new int[0];
            }
            int lenA = slotsA.GetLength(0);
            int lenB = slotsB.GetLength(0);

            //edge cases
            if (lenA < 1 || lenB < 1 || (lenA + lenB) == 1)
            {
                return new int[0];
            }

            int indexA = 0;
            int indexB = 0;

            //slotsA = [[10, 50], [60, 120], [140, 210]]
            //slotsB = [[0, 15], [60, 70]]
            //dur = 8
            while (indexA < lenA && indexB < lenB)
            {
                int[] commonSlot = FindCommonSlot(slotsA[indexA, 0], slotsA[indexA, 1], slotsB[indexB, 0], slotsB[indexB, 1]);
                if (commonSlot.Length > 0 && (commonSlot[1] - commonSlot[0]) >= dur)
                {
                    return new int[2] { commonSlot[0], commonSlot[0] + dur };
                }
                if (slotsA[indexA, 1] > slotsB[indexB, 1])
                {
                    indexB++;
                }
                else
                {
                    indexA++;
                }
            }

            return new int[0];
        }




        // reverses the order of the words in the array in the most efficient manner.
        // time: O(n)
        // space: O(1)
        public static char[] ReverseWords(char[] arr)
        {
            if (arr == null || arr.Length <= 1)
            {
                return arr;
            }

            //step 1: reverse the whole array
            ReverseChars(arr, 0, arr.Length - 1);

            //step 2: reverse every word
            for (int i = 0; i < arr.Length; i++)
            {
                int left = i;
                while (i < arr.Length && arr[i] != ' ')
                {
                    i++;
                }

                int right = i - 1;
                ReverseChars(arr, left, right);
            }

            return arr;
        }

        // helper method for ReverseWords
        private static void ReverseChars(char[] arr, int start, int end)
        {
            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        // finds in the most efficient manner a cap such that the least number of recipients is impacted and that the new budget constraint is met 
        // time: O(nlogn)
        // space: O(1)
        public static double FindGrantsCap(double[] grantsArray, double newBudget)
        {
            //edge cases
            if (grantsArray == null || grantsArray.Length == 0)
            {
                return 0;
            }

            double sum = grantsArray.Sum();
            double exceedingBudget = sum - newBudget;
            if (exceedingBudget <= 0)
            {
                return grantsArray[0];
            }

            // sort array in descending order
            Array.Sort(grantsArray);
            Array.Reverse(grantsArray);
            double grantsCap = 0;
            int n = grantsArray.Length;
            for (int i = 1; i < n; i++)
            {
                exceedingBudget -= (grantsArray[i - 1] - grantsArray[i]) * i;
                if (exceedingBudget == 0)
                {
                    grantsCap = grantsArray[i];
                    break;
                }

                if (exceedingBudget < 0)
                {
                    grantsCap = Math.Abs(exceedingBudget) / i + grantsArray[i];
                    break;
                }
            }

            if (exceedingBudget > 0)
            {
                exceedingBudget -= grantsArray[n - 1] * n;
                grantsCap = Math.Abs(exceedingBudget) / n;
            }

            return grantsCap;
        }

        //returns true if the text matches the pattern as a regular expression.
        //supports the '.' and '*' symbols
        public static bool IsMatchRegex(string text, string pattern)
        {
            return IsMatch(text, pattern, 0, 0);
        }

        //helper recursive function for IsMatch()
        //time: O(2^n)
        //space: O(2^n)
        private static bool IsMatch(string text, string pattern, int i, int j)
        {
            Console.WriteLine($"IsMatch({text}[{i}],{pattern}[{j}])");
            if (i >= text.Length && j >= pattern.Length)
            {
                return true;
            }

            if (j >= pattern.Length)
            {
                Console.WriteLine($"j >= pattern.Length -> FALSE");
                return false;
            }

            if (j + 1 < pattern.Length && pattern[j + 1] == '*')
            {
                if (i >= text.Length)
                {
                    return IsMatch(text, pattern, i, j + 2);
                }

                if (pattern[j] == '.' || text[i] == pattern[j])
                {
                    return IsMatch(text, pattern, i + 1, j) || IsMatch(text, pattern, i, j + 2);
                }
                else
                {
                    return IsMatch(text, pattern, i, j + 2);
                }
            }

            if (i >= text.Length)
            {
                Console.WriteLine($"i >= text.Length -> FALSE");
                return false;
            }


            if (pattern[j] == '.' || text[i] == pattern[j])
            {
                return IsMatch(text, pattern, i + 1, j + 1);
            }

            if (pattern[j] != text[i])
            {
                Console.WriteLine($"pattern[j] != text[i] -> FALSE");
                return false;
            }

            Console.WriteLine($"FALSE");
            return false;

        }

        // finds the smallest substring of str containing all the characters in arr
        // time: O(n+m)
        // space: O(m)
        public static string GetShortestUniqueSubstring(char[] arr, string str)
        {
            int head = 0;
            string result = "";
            int uniqueCounter = 0;
            var countMap = new Dictionary<char, int>();
            foreach (char ch in arr)
            {
                countMap.Add(ch, 0);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (countMap.ContainsKey(str[i]))
                {
                    if (countMap[str[i]] == 0)
                    {
                        uniqueCounter++;
                    }

                    countMap[str[i]]++;

                    //push head forward
                    while (uniqueCounter == arr.Length)
                    {
                        int tempLength = i - head + 1;
                        if (tempLength == arr.Length)
                        {
                            return str.Substring(head, tempLength);
                        }

                        if (result == "" || tempLength < result.Length)
                        {
                            result = str.Substring(head, tempLength);
                        }

                        if (countMap.ContainsKey(str[head]))
                        {
                            countMap[str[head]]--;
                            if (countMap[str[head]] == 0)
                            {
                                uniqueCounter--;
                            }
                        }

                        head++;
                    }
                }
            }

            return result;
        }

        // (4Sum) finds four numbers (quadruplet) in arr that sum == s
        // return an array of these numbers in an ascending order
        // time: O(n^3)
        // space: O(1)
        public static int[] FindArrayQuadruplet(int[] arr, int s)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 3; i++)
            {
                for (int j = i + 1; j < arr.Length - 2; j++)
                {
                    int sumOfPair1 = arr[i] + arr[j];
                    int r = s - sumOfPair1;
                    int low = j + 1;
                    int high = arr.Length - 1;
                    //now we look for low and high, such that arr[low]+arr[high] == r
                    while (low < high)
                    {
                        int sumOfPair2 = arr[low] + arr[high];
                        if (sumOfPair2 == r)
                        {
                            return new[] { arr[i], arr[j], arr[low], arr[high] };
                        }
                        else if (sumOfPair2 > r)
                        {
                            high--;
                        }
                        else
                        {
                            low++;
                        }
                    }
                }
            }

            return new int[0];
        }

        // helper method to print array
        // O(n)
        public static string ArrayToString(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i].ToString()).Append(", ");
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        // returns a flattened version of dictionary, that can contain inner dictionaries
        // time: O(n)
        // space: O(n)
        public static Dictionary<string, string> FlattenDictionary(Dictionary<string, object> dict)
        {
            var flatDict = new Dictionary<string, string>();
            foreach (var keyValue in dict)
            {

                if (keyValue.Value is string)
                {
                    flatDict[keyValue.Key] = keyValue.Value as string;
                }

                if (keyValue.Value is Dictionary<string, Object>)
                {
                    var nestedDictionary = FlattenDictionary(keyValue.Value as Dictionary<string, Object>);
                    foreach (var nestedPair in nestedDictionary)
                    {
                        if (nestedPair.Key == string.Empty)
                        {
                            flatDict[keyValue.Key] = nestedPair.Value;
                        }
                        else if (keyValue.Key == string.Empty)
                        {
                            flatDict[nestedPair.Key] = nestedPair.Value;
                        }
                        else
                        {
                            flatDict[$"{keyValue.Key }.{nestedPair.Key}"] = nestedPair.Value;
                        }
                    }
                }
            }
            return flatDict;
        }

        // that returns the number of the possible paths the driverless car can take
        // time: O(n^2)
        // space: O(n^2)
        public static int NumOfPathsToDest(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i == 0)
                    {
                        // first row
                        matrix[i, j] = 1;

                    }
                    else if (i == j)
                    {
                        // diagonal
                        matrix[i, j] = matrix[i - 1, j];

                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 1] + matrix[i - 1, j];

                    }
                }
            }

            return matrix[n - 1, n - 1];
        }

        // sort the array into a wave 
        // arrange the elements into a sequence such that a1 >= a2 <= a3 >= a4 <= a5..
        // time: O(n)
        // size: O(1)
        public static List<int> SortToWave(List<int> A)
        {
            if (A == null || A.Count() < 2)
            {
                return A;
            }

            A.Sort();
            for (int i = 1; i < A.Count(); i += 2)
            {
                Swap(A, i, i - 1);
            }

            return A;
        }

        private static void Swap(List<int> A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        // sorting problem 
        // Given [3, 30, 34, 5, 9], the largest formed number is 9534330
        public static string LargestNumber(List<int> A)
        {
            List<string> a2 = A.ConvertAll<string>(x => x.ToString());


            a2.Sort((a, b) =>
            {
                long ab = long.Parse(a + b);
                long ba = long.Parse(b + a);
                if (ab > ba)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });


            if (a2[0][0].Equals('0'))
            {
                return "0";
            }

            var res = String.Concat(a2.ToArray());

            return res;
        }

        // prints min number of bribes(swaps) needed to make array be ordered a[i]=i
        public static void MinimumBribes(int[] a)
        {
            int bribes = 0;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == i + 1)
                        continue;
                    if (a[i] > i + 3)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }

                    if (a[i] == i + 2 || a[i] == i + 3)
                    {
                        if (a[i] > a[i + 1])
                        {
                            Swap(a, i, i + 1);
                            bribes++;
                        }
                    }

                    if (a[i] != i + 1)
                    {
                        sorted = false;
                    }
                }
            }

            Console.WriteLine(bribes);
        }

        public static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }


        // Sum 2 numbers in strings, without using casting to numbers
        public static string SumStringNumbers(string s1, string s2)
        {
            // edge cases
            if (string.IsNullOrEmpty(s1))
            {
                if (string.IsNullOrEmpty(s2))
                {
                    return string.Empty;
                }
                else
                {
                    return s2;
                }
            }

            if (string.IsNullOrEmpty(s2))
            {
                return s1;
            }

            string longerS;
            string shorterS;
            if (s1.Length < s2.Length)
            {
                longerS = s2;
                shorterS = s1;
            }
            else
            {
                longerS = s1;
                shorterS = s2;
            }

            int indexShorter = shorterS.Length - 1;
            int indexLonger = longerS.Length - 1;

            var answer = new char[longerS.Length];
            int indexAnswer = 0;

            bool oneFromLastSum = false;
            while (indexShorter >= 0)
            {
                string sumChars = SumChars(shorterS[indexShorter], longerS[indexLonger], oneFromLastSum);
                answer[indexAnswer] = sumChars[sumChars.Length - 1];
                oneFromLastSum = sumChars.Length > 1;

                indexShorter--;
                indexLonger--;
                indexAnswer++;
            }

            while (indexLonger >= 0)
            {
                if (oneFromLastSum)
                {
                    string sumChars = SumChars(longerS[indexLonger], '0', oneFromLastSum);
                    answer[indexAnswer] = sumChars[sumChars.Length - 1];
                    oneFromLastSum = sumChars.Length > 1;
                }
                else
                {
                    answer[indexAnswer] = longerS[indexLonger];
                }

                indexLonger--;
                indexAnswer++;
            }

            if (oneFromLastSum)
            {
                char[] answerPlusOne = new char[answer.Length + 1];
                Array.Copy(answer, answerPlusOne, answer.Length);
                answerPlusOne[answer.Length] = '1';
                answer = answerPlusOne;
            }

            Array.Reverse(answer);

            return new string(answer);
        }

        // ASCII 0-9 (48-57)
        public static string SumChars(char c1, char c2, bool toAddOne = false)
        {
            //edge case
            if (c1 < '0' || c1 > '9' || c2 < '0' || c2 > '9')
            {
                return string.Empty;
            }

            int sum = (c1 + c2 - '0') + (toAddOne ? 1 : 0);
            if (sum > '9')
            {
                sum -= 10;
                return "1" + Convert.ToChar(sum);
            }

            return Convert.ToChar(sum) + "";
        }

        // n — the number of types of bottles in the store 
        // L — the required amount of child milk in liters.
        // c1, c2, ..., cn — the costs of bottles of different types.
        // Output a single integer — the smallest number of cents you have to pay in order to buy at least L liters of child milk.
        public static long findHowMuchCentsToSpend(int n, int L, long[] c)
        {
            // make c[i] = min(c[i], ..., c[n])
            for (int i = n - 2; i >= 0; i--)
            {
                if (c[i + 1] < c[i])
                {
                    c[i] = c[i + 1];
                }
            }
            long biggestVolume = (long)Math.Pow(2, n - 1);

            var minSpend = new long[biggestVolume + 1];
            minSpend[0] = 0;
            minSpend[1] = c[0];
            long lowerVolume = 1;
            long upperVolume = 2;
            int upperVolumeIndex = 1;


            for (int i = 2; i < biggestVolume + 1; i++)
            {
                if (i > upperVolume)
                {
                    lowerVolume = upperVolume;
                    upperVolume *= 2;
                    upperVolumeIndex++;
                }

                minSpend[i] = Math.Min(
                    c[upperVolumeIndex],
                    minSpend[lowerVolume] + minSpend[i - lowerVolume]);

            }

            long sumSpend = L / biggestVolume * minSpend[biggestVolume] + minSpend[L % biggestVolume];
            return sumSpend;
        }

        // Copies inputMatrix’s values into a 1D array in a spiral order, clockwise.
        // time: O(N*M)
        // space: O(N*M)
        public static int[] SpiralCopy(int[,] inputMatrix)
        {
            int rowStart = 0;
            int rowEnd = inputMatrix.GetLength(0) - 1;
            int colStart = 0;
            int colEnd = inputMatrix.GetLength(1) - 1;

            int[] arr = new int[(rowEnd + 1) * (colEnd + 1)];
            int index = 0;
            //arr[index++] = inputMatrix[0, 0];
            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int col = colStart; col <= colEnd; col++)
                {
                    arr[index++] = inputMatrix[rowStart, col];
                }

                for (int row = rowStart + 1; row <= rowEnd; row++)
                {
                    arr[index++] = inputMatrix[row, colEnd];
                }

                if (rowEnd > rowStart)
                {
                    for (int col = colEnd - 1; col >= colStart; col--)
                    {
                        arr[index++] = inputMatrix[rowEnd, col];
                    }
                }

                rowStart++;

                if (colEnd > colStart)
                {
                    for (int row = rowEnd - 1; row >= rowStart; row--)
                    {
                        arr[index++] = inputMatrix[row, colStart];
                    }
                }
                rowEnd--;
                colStart++;
                colEnd--;
            }
            return arr;
        }


        // Check if a string has all characters with same frequency with one variation allowed
        // time: O(N)
        public static bool IsSameCharFrequency(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            var charFreq = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (charFreq.ContainsKey(c))
                {
                    charFreq[c]++;
                }
                else
                {
                    charFreq[c] = 1;
                }
            }
            var freqFreq = new Dictionary<int,int>();
            foreach (var freq in charFreq.Values)
            {
                if (freqFreq.ContainsKey(freq))
                {
                    freqFreq[freq]++;
                }
                else
                {
                    freqFreq[freq] = 1;
                }
            }

            if (freqFreq.Count > 2)
            {
                return false;
            }

            if (freqFreq.Count == 2)
            {
                int firstFreqCount = freqFreq.Values.First();
                int lastFreqCount = freqFreq.Values.Last();
                if (firstFreqCount > 1 && lastFreqCount > 1)
                {
                    return false;
                }
                
                int firstFreq = freqFreq.Keys.First();
                int lastFreq = freqFreq.Keys.Last();
                if(firstFreq == 1 && firstFreqCount == 1
                    || lastFreq == 1 && lastFreqCount == 1)
                {
                    return true;
                }
                if (Math.Abs(firstFreq - lastFreq) > 1)
                {
                    return false;
                }
            }
            return true;
        }

        // east -> 3 1 4 2 3 1 -> west
        //  4          |
        //  3      |   |   |
        //  2      |   | | | 
        //  1      | | | | | |
        // input:  3 1 4 2 3 1
        // output:     4   3 1
        public static List<int> GetHousesWithDawnView(IEnumerable<int> housesHeights)
        {
            var houses = new Stack<int>();
            foreach (var houseHeight in housesHeights)
            {
                while (houses.Count > 0 && houses.Peek() < houseHeight)
                {
                    houses.Pop();
                }
                houses.Push(houseHeight);
            }

            return houses.ToList();
        }

        public static bool IsContainSubstringPermutation(string str, string substr)
        {
            if (str == null || substr == null)
            {
                throw new ArgumentException();
            }
            if(substr == "")
            {
                return true;
            }
            if (substr.Length > str.Length)
            {
                return false;
            }
            var substrMap = new Dictionary<char, int>();
            var currentWindowMap = new Dictionary<char, int> ();
            foreach(char c in substr)
            {
                if(substrMap.ContainsKey(c))
                {
                    substrMap[c]++;
                }
                else
                {
                    substrMap[c] = 1;
                }
            }

            int start = 0;
            int end = substr.Length - 1;
            for(int i = 0; i <= end; i++)
            {
                if (currentWindowMap.ContainsKey(str[i]))
                {
                    currentWindowMap[str[i]]++;
                }
                else
                {
                    currentWindowMap[str[i]] = 1;
                }
            }

            do
            {
                //Compare Maps
                foreach (var keyValue in substrMap)
                {
                    if (currentWindowMap[keyValue.Key] != keyValue.Value)
                    {
                        return false;
                    }
                }
                start++;
                end++;
            } while (end < str.Length);

            return false;
        }
    }
}

