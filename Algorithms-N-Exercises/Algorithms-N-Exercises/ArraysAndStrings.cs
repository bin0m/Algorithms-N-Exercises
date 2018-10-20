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
        // O(1)
        private static int[] FindCommonTimeInterval(int[] slotA, int[] slotB)
        {
            if (slotA[0] > slotB[1] || slotB[0] > slotA[1])
            {
                return null;
            }
            int startCommonTime = Math.Max(slotA[0], slotB[0]);
            int endCommonTime = Math.Min(slotA[1], slotB[1]);
            return new[] { startCommonTime, endCommonTime };
        }

        // returns the earliest time slot that works for both of them and is of duration dur
        // time: O(n+m)
        // space: O(1)
        public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int indexA = 0;
            int indexB = 0;
            while (indexA < slotsA.Length / 2 && indexB < slotsB.Length / 2)
            {
                var commonTime = FindCommonTimeInterval(new[] { slotsA[indexA, 0], slotsA[indexA, 1] },
                                       new[] { slotsB[indexB, 0], slotsB[indexB, 1] });
                if (commonTime != null)
                {
                    var maxDuration = commonTime[1] - commonTime[0];
                    if (maxDuration > dur)
                    {
                        commonTime[1] = commonTime[0] + dur;
                        return commonTime;
                    }
                    else if (maxDuration == dur)
                    {
                        return commonTime;
                    }
                }

                if (indexA == slotsA.GetUpperBound(0) ||
                   (slotsA[indexA, 1] > slotsB[indexB, 1]) && (indexB != slotsB.GetUpperBound(0)))
                {
                    indexB++;
                }
                else
                {
                    indexA++;
                }
            }
            return null;
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
                if( keyValue.Value is string)
                {
                    flatDict.Add(keyValue.Key, keyValue.Value as string);
                }
                else
                {
                    var subDict = FlattenDictionary(keyValue.Value as Dictionary<string, object>);
                    foreach (var subDictPair in subDict)
                    {
                        flatDict.Add($"{keyValue}.{subDictPair.Key}", subDictPair.Value);
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
    }
}
