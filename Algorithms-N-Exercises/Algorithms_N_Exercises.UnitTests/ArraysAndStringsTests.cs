using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_N_Exercises.UnitTests
{
    [TestClass]
    public class ArraysAndStringsTests
    {
        [TestMethod]
        public void IsStringUniqueTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("a"));
        }

        [TestMethod]
        public void IsStringUniqueTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique("aa"));
        }

        [TestMethod]
        public void IsStringUniqueTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("aA"));
        }

        [TestMethod]
        public void IsStringUniqueTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique("a b5<;"));
        }
        [TestMethod]
        public void IsStringUniqueTest5()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique("X b5<;-X"));
        }

        [TestMethod]
        public void IsStringUnique2Test1()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("a"));
        }

        [TestMethod]
        public void IsStringUnique2Test2()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique2("aa"));
        }

        [TestMethod]
        public void IsStringUnique2Test3()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("aA"));
        }

        [TestMethod]
        public void IsStringUnique2Test4()
        {
            Assert.IsTrue(ArraysAndStrings.IsStringUnique2("a b5<;"));
        }

        [TestMethod]
        public void IsStringUnique2Test5()
        {
            Assert.IsFalse(ArraysAndStrings.IsStringUnique2("X b5<;-X"));
        }

        [TestMethod]
        public void CheckPermutationTest1()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("a", "a"));
        }

        [TestMethod]
        public void CheckPermutationTest2()
        {
            Assert.IsFalse(ArraysAndStrings.CheckPermutation("abb", "ab"));
        }

        [TestMethod]
        public void CheckPermutationTest3()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("AB", "BA"));
        }

        [TestMethod]
        public void CheckPermutationTest4()
        {
            Assert.IsFalse(ArraysAndStrings.CheckPermutation("AB", "bA"));
        }

        [TestMethod]
        public void CheckPermutationTest5()
        {
            Assert.IsTrue(ArraysAndStrings.CheckPermutation("abcd", "dbac"));
        }

        [TestMethod]
        public void MeetingPlannerTest1()
        {
            var slotA = new[,] { { 7, 12 } };
            var slotB = new[,] { { 2, 11 } };
            int dur = 5;
            CollectionAssert.AreEqual(new int[0], ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest2()
        {
            var slotA = new[,] { { 6, 12 } };
            var slotB = new[,] { { 2, 11 } };
            int dur = 5;
            CollectionAssert.AreEqual(new[] { 6, 11 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest3()
        {
            var slotA = new[,] { { 1, 10 } };
            var slotB = new[,] { { 2, 3 }, { 5, 7 } };
            int dur = 2;
            CollectionAssert.AreEqual(new[] { 5, 7 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest4()
        {
            var slotA = new[,] { { 0, 5 }, { 50, 70 }, { 120, 125 } };
            var slotB = new[,] { { 0, 50 } };
            int dur = 8;
            CollectionAssert.AreEqual(new int[0], ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void MeetingPlannerTest5()
        {
            var slotA = new[,] { { 10, 50 }, { 60, 120 }, { 140, 210 } };
            var slotB = new[,] { { 0, 15 }, { 60, 70 } };
            int dur = 8;
            CollectionAssert.AreEqual(new[] { 60, 68 }, ArraysAndStrings.MeetingPlanner(slotA, slotB, dur));
        }

        [TestMethod]
        public void ReverseWordsTest1()
        {
            CollectionAssert.AreEqual(new[] { 'm', 'e', ' ', 'y', 'o', 'u' }, ArraysAndStrings.ReverseWords(new[] { 'y', 'o', 'u', ' ', 'm', 'e' }));
        }

        [TestMethod]
        public void ReverseWordsTest2()
        {
            CollectionAssert.AreEqual(new[] { ' ', ' '}, ArraysAndStrings.ReverseWords(new[] { ' ', ' ' }));
        }

        [TestMethod]
        public void ReverseWordsTest3()
        {
            CollectionAssert.AreEqual(new[] { ' ', 'a' }, ArraysAndStrings.ReverseWords(new[] { 'a', ' ' }));
        }


        [TestMethod]
        public void ReverseWordsTest4()
        {
            CollectionAssert.AreEqual(new[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e',' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' }, ArraysAndStrings.ReverseWords(new[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' }));
        }

        [TestMethod]
        public void ReverseWordsTest5()
        {
            CollectionAssert.AreEqual(new[] { 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c', 't' }, ArraysAndStrings.ReverseWords(new[] { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' }));
        }

        [TestMethod]
        public void FindGrantsCapTest1()
        {
            Assert.AreEqual(1.5, ArraysAndStrings.FindGrantsCap(new double[] { 2, 4 }, 3));
        }

        [TestMethod]
        public void FindGrantsCapTest2()
        {
            Assert.AreEqual(47, ArraysAndStrings.FindGrantsCap(new double[] { 2, 100, 50, 120, 1000 }, 190));
        }

        [TestMethod]
        public void FindGrantsCapTest3()
        {
            Assert.AreEqual(1, ArraysAndStrings.FindGrantsCap(new double[] { 2, 4, 6 }, 3));
        }

        [TestMethod]
        public void FindGrantsCapTest4()
        {
            Assert.AreEqual(128, ArraysAndStrings.FindGrantsCap(new double[] { 2, 100, 50, 120, 167 }, 400));
        }

        [TestMethod]
        public void FindGrantsCapTest5()
        {
            Assert.AreEqual(23.8, ArraysAndStrings.FindGrantsCap(new double[] { 21, 100, 50, 120, 130, 110 }, 140));
        }

        [TestMethod]
        public void IsMatchRegexTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("", ""));
        }

        [TestMethod]
        public void IsMatchRegexTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsMatchRegex("aa", "a"));
        }

        [TestMethod]
        public void IsMatchRegexTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("bb", "bb"));
        }

        [TestMethod]
        public void IsMatchRegexTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("bb", "bb"));
        }

        [TestMethod]
        public void IsMatchRegexTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("aba", "a.a"));
        }

        [TestMethod]
        public void IsMatchRegexTest6()
        {
            Assert.IsTrue(ArraysAndStrings.IsMatchRegex("abaa", "a.*a*"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("a"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest2()
        {
            Assert.IsFalse(ArraysAndStrings.IsPalindromePermutation("ba"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("aA"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("bba"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsPalindromePermutation("aabb"));
        }

        [TestMethod]
        public void IsPalindromePermutationTest6()
        {
            Assert.IsFalse(ArraysAndStrings.IsPalindromePermutation("aaab"));
        }

        [TestMethod]
        public void IsOneAwayTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("", ""));
        }
        [TestMethod]
        public void IsOneAwayTest2()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("a", ""));
        }

        [TestMethod]
        public void IsOneAwayTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("", "a"));
        }

        [TestMethod]
        public void IsOneAwayTest4()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("pale", "ple"));
        }

        [TestMethod]
        public void IsOneAwayTest5()
        {
            Assert.IsTrue(ArraysAndStrings.IsOneAway("pale", "bale"));
        }

        [TestMethod]
        public void IsOneAwayTest6()
        {
            Assert.IsFalse(ArraysAndStrings.IsOneAway("pale", "bake"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest1()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, ""));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest2()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, "b"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest3()
        {
            Assert.AreEqual("a", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a' }, "a"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest4()
        {
            Assert.AreEqual("acb", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'a', 'b' }, "-acb"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest5()
        {
            Assert.AreEqual("zyx", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z' }, "xyyzyzyx"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest6()
        {
            Assert.AreEqual("", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z', 'r' }, "xyyzyzyx"));
        }

        [TestMethod]
        public void GetShortestUniqueSubstringTest7()
        {
            Assert.AreEqual("zyxr", ArraysAndStrings.GetShortestUniqueSubstring(new[] { 'x', 'y', 'z', 'r' }, "xyyzyzyxr"));
        }

        [TestMethod]
        public void FlattenDictionaryTest1()
        {
            var inputDict = new Dictionary<string, object>();
            inputDict.Add("key1", "1");
            var expectedDict = new Dictionary<string, string>();
            expectedDict.Add("key1", "1");
            CollectionAssert.AreEqual(expectedDict, ArraysAndStrings.FlattenDictionary(inputDict));
        }

        [TestMethod]
        public void FlattenDictionaryTest2()
        {
            var inputDict = new Dictionary<string, object>
            {
                {"key1", "1"},
                {"key2", new Dictionary<string, object>()
                {
                    {"a", "24"},
                    { "", "25"}
                }}
            };
            var expectedDict = new Dictionary<string, string>
            {
                { "key1", "1"},
                { "key2.a", "24"},
                { "key2", "25"}
            };
            CollectionAssert.AreEqual(expectedDict, ArraysAndStrings.FlattenDictionary(inputDict));
        }

        [TestMethod]
        public void FlattenDictionaryTest3()
        {
            var inputDict = new Dictionary<string, object>
            {
                { "key1", "1"},
                { "", new Dictionary<string, object>()
                {
                    { "key12", "24"},
                    { "key23", new Dictionary<string, object>()
                    {
                        { "a", "345"},
                        { "b", "346"}
                    }}
                }}
            };
            var expectedDict = new Dictionary<string, string>
            {
                { "key1", "1"},
                { "key12", "24"},
                { "key23.a", "345"},
                { "key23.b", "346"}
            };
            CollectionAssert.AreEqual(expectedDict, ArraysAndStrings.FlattenDictionary(inputDict));
        }

        [TestMethod]
        public void NumOfPathsToDestTest1()
        {
            Assert.AreEqual(1, ArraysAndStrings.NumOfPathsToDest(1));
        }

        [TestMethod]
        public void NumOfPathsToDestTest2()
        {
            Assert.AreEqual(1, ArraysAndStrings.NumOfPathsToDest(2));
        }

        [TestMethod]
        public void NumOfPathsToDestTest3()
        {
            Assert.AreEqual(2, ArraysAndStrings.NumOfPathsToDest(3));
        }

        [TestMethod]
        public void NumOfPathsToDestTest4()
        {
            Assert.AreEqual(5, ArraysAndStrings.NumOfPathsToDest(4));
        }

        [TestMethod]
        public void NumOfPathsToDestTest5()
        {
            Assert.AreEqual(14, ArraysAndStrings.NumOfPathsToDest(5));
        }

        [TestMethod]
        public void NumOfPathsToDestTest6()
        {
            Assert.AreEqual(35357670, ArraysAndStrings.NumOfPathsToDest(17));
        }

        [TestMethod]
        public void IsPrimeTest1()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("a"));
        }

        [TestMethod]
        public void IsPrimeTest2()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("ab"));
        }

        [TestMethod]
        public void IsPrimeTest3()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("aba"));
        }

        [TestMethod]
        public void IsPrimeTest4()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("aa"));
        }

        [TestMethod]
        public void IsPrimeTest5()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("abab"));
        }

        [TestMethod]
        public void IsPrimeTest6()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("abcab"));
        }

        [TestMethod]
        public void IsPrimeTest7()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("abcabc"));
        }

        [TestMethod]
        public void IsPrimeTest8()
        {
            Assert.IsTrue(ArraysAndStrings.IsPrime("abcabdc"));
        }

        [TestMethod]
        public void IsPrimeTest9()
        {
            Assert.IsFalse(ArraysAndStrings.IsPrime("ababab"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest1()
        {
            Assert.IsTrue(ArraysAndStrings.CanBeWrittenFrom("a", "a"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest2()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("aa", "abcd"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest3()
        {
            Assert.IsTrue(ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,,%ar0O"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest4()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("a,O,", "qpz,%ar0O"));
        }

        [TestMethod]
        public void CanBeWrittenFromTest5()
        {
            Assert.IsFalse(ArraysAndStrings.CanBeWrittenFrom("abba", "Banda b"));
        }

        [TestMethod]
        public void MinimumBribesTest1()
        {
            var input = new[] {1};
            var expected = "0";

            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest2()
        {
            var input = new[] { 2, 1 };
            var expected = "1";

            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest3()
        {
            var input = new[] { 2, 3, 1 };
            var expected = "2";

            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest4()
        {
            var input = new[] { 3, 2, 1 };
            var expected = "3";

            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest5()
        {
            var input = new[] { 4, 3, 2, 1 };
            var expected = "Too chaotic";

            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest6()
        {
            var input = new[] { 3, 4, 1, 2 };
            var expected = "4";

            // Needed to test a method which writes to the Console to validate the output
            MinimumBribeTestHelper(input, expected);
        }

        [TestMethod]
        public void MinimumBribesTest7()
        {
            var input = new[] { 3, 4, 2, 1 };
            var expected = "5";

            MinimumBribeTestHelper(input, expected);
        }

        private void MinimumBribeTestHelper(int[] input, string expected)
        {
            // Needed to test a method which writes to the Console to validate the output
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                ArraysAndStrings.MinimumBribes(input);
                Assert.AreEqual(expected + "\r\n", consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void SumStringNumbersTest1()
        {
            Assert.AreEqual("", ArraysAndStrings.SumStringNumbers(null, null));
        }

        [TestMethod]
        public void SumStringNumbersTest2()
        {
            Assert.AreEqual("2", ArraysAndStrings.SumStringNumbers("2", null));
        }

        [TestMethod]
        public void SumStringNumbersTest3()
        {
            Assert.AreEqual("3", ArraysAndStrings.SumStringNumbers("", "3"));
        }

        [TestMethod]
        public void SumStringNumbersTest4()
        {
            Assert.AreEqual("4", ArraysAndStrings.SumStringNumbers("4", "0"));
        }

        [TestMethod]
        public void SumStringNumbersTest5()
        {
            Assert.AreEqual("5", ArraysAndStrings.SumStringNumbers("1", "4"));
        }

        [TestMethod]
        public void SumStringNumbersTest6()
        {
            Assert.AreEqual("16", ArraysAndStrings.SumStringNumbers("9", "7"));
        }

        [TestMethod]
        public void SumStringNumbersTest7()
        {
            Assert.AreEqual("100", ArraysAndStrings.SumStringNumbers("15", "85"));
        }

        [TestMethod]
        public void SumStringNumbersTest8()
        {
            Assert.AreEqual("5170", ArraysAndStrings.SumStringNumbers("6", "5164"));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest1()
        {
            Assert.AreEqual(150, ArraysAndStrings.FindHowMuchCentsToSpend(4,12,new long[]{20,30,70,90}));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest2()
        {
            Assert.AreEqual(10, ArraysAndStrings.FindHowMuchCentsToSpend(4, 3, new long[] { 10000, 1000, 100, 10 }));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest3()
        {
            Assert.AreEqual(30, ArraysAndStrings.FindHowMuchCentsToSpend(4, 3, new long[] { 10, 100, 1000, 10000 }));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest6()
        {
            Assert.AreEqual(120, ArraysAndStrings.FindHowMuchCentsToSpend(4, 12, new long[] { 10, 100, 1000, 10000 }));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest4()
        {
            Assert.AreEqual(44981600785557577, ArraysAndStrings.FindHowMuchCentsToSpend(5, 787787787, new long[] { 123456789, 234567890, 345678901, 456789012 , 987654321 }));
        }

        [TestMethod]
        public void FindHowMuchCentsToSpendTest5()
        {
            Assert.AreEqual(170, ArraysAndStrings.FindHowMuchCentsToSpend(4, 13, new long[] { 26, 30, 70, 85 }));
        }

        [TestMethod]
        public void SpiralCopyTest1()
        {
            CollectionAssert.AreEqual(new[]{1}, ArraysAndStrings.SpiralCopy(new[,]{{1}}));
        }

        [TestMethod]
        public void SpiralCopyTest2()
        {
            CollectionAssert.AreEqual(new[] { 1, 2 }, ArraysAndStrings.SpiralCopy(new[,] { { 1, 2 } }));
        }

        [TestMethod]
        public void SpiralCopyTest3()
        {
            CollectionAssert.AreEqual(new[] { 1, 2 }, ArraysAndStrings.SpiralCopy(new[,] { { 1 }, { 2 } }));
        }

        [TestMethod]
        public void SpiralCopyTest4()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 3 }, ArraysAndStrings.SpiralCopy(new[,] { { 1, 2 }, { 3, 4 } }));
        }

        [TestMethod]
        public void SpiralCopyTest5()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 6, 5, 4 }, ArraysAndStrings.SpiralCopy(new[,] { { 1, 2, 3 }, { 4, 5, 6 } }));
        }

        [TestMethod]
        public void SpiralCopyTest6()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, ArraysAndStrings.SpiralCopy(new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }));
        }

        [TestMethod]
        public void SpiralCopyTest7()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 10, 15, 20, 19, 18, 17, 16, 11, 6, 7, 8, 9, 14, 13, 12 }, ArraysAndStrings.SpiralCopy(new[,] { { 1, 2, 3, 4 , 5 }, { 6,7,8,9,10 }, { 11, 12, 13, 14 ,15 }, { 16, 17, 18, 19, 20 } }));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest1()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency(""));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest2()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("a"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest3()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("aaa"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest4()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("abbb"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest5()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("abbccdd"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest6()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("abbb"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest7()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("aabbb"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest8()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("aaabbbb"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest9()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsSameCharFrequency("abbccc"));
        }
        
        [TestMethod]
        public void IsSameCharFrequencyTest10()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsSameCharFrequency("aabbcd"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest11()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsSameCharFrequency("aabbbb"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest12()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsSameCharFrequency("aabbcccddd"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest13()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsSameCharFrequency("aacccddd"));
        }

        [TestMethod]
        public void IsSameCharFrequencyTest14()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsSameCharFrequency("aabbcccc")); 
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest1()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsContainSubstringPermutation3("a","a"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest2()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsContainSubstringPermutation3("a", "b"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest3()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsContainSubstringPermutation3("ab", "b"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest4()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsContainSubstringPermutation3("abab", "bb"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest5()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsContainSubstringPermutation3("dcda", "adc"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest6()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsContainSubstringPermutation3("bacabc", "acc"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest7()
        {
            Assert.AreEqual(true, ArraysAndStrings.IsContainSubstringPermutation3("ccbacabcaca", "acac"));
        }

        [TestMethod]
        public void IsContainSubstringPermutationTest8()
        {
            Assert.AreEqual(false, ArraysAndStrings.IsContainSubstringPermutation3("ccbacabcac", "acac"));
        }

        [TestMethod]
        public void DeletionDistanceTest1()
        {
            Assert.AreEqual(2, ArraysAndStrings.DeletionDistance("a", "b"));
        }

        [TestMethod]
        public void DeletionDistanceTest2()
        {
            Assert.AreEqual(1, ArraysAndStrings.DeletionDistance("a", "ba"));
        }

        [TestMethod]
        public void DeletionDistanceTest3()
        {
            Assert.AreEqual(2, ArraysAndStrings.DeletionDistance("ab", "ba"));
        }

        [TestMethod]
        public void DeletionDistanceTest4()
        {
            Assert.AreEqual(3, ArraysAndStrings.DeletionDistance("abc", "ba"));
        }

        [TestMethod]
        public void DeletionDistanceTest5()
        {
            Assert.AreEqual(3, ArraysAndStrings.DeletionDistance("", "hit"));
        }

        [TestMethod]
        public void DeletionDistanceTest6()
        {
            Assert.AreEqual(3, ArraysAndStrings.DeletionDistance("heat", "hit"));
        }

        [TestMethod]
        public void DeletionDistanceTest7()
        {
            Assert.AreEqual(2, ArraysAndStrings.DeletionDistance("hot", "not"));
        }

        [TestMethod]
        public void DeletionDistanceTest8()
        {
            Assert.AreEqual(1, ArraysAndStrings.DeletionDistance("abc", "adbc"));
        }

        [TestMethod]
        public void MinWindowTest1()
        {
            Assert.AreEqual("a", ArraysAndStrings.MinWindow("a", "a"));
        }

        [TestMethod]
        public void MinWindowTest2()
        {
            Assert.AreEqual("a", ArraysAndStrings.MinWindow("bac", "a"));
        }

        [TestMethod]
        public void MinWindowTest3()
        {
            Assert.AreEqual("ac", ArraysAndStrings.MinWindow("bac", "ca"));
        }

        [TestMethod]
        public void MinWindowTest4()
        {
            Assert.AreEqual("", ArraysAndStrings.MinWindow("bac", "cac"));
        }

        [TestMethod]
        public void MinWindowTest5()
        {
            Assert.AreEqual("t stri", ArraysAndStrings.MinWindow("this is a test string", "tist"));
        }

        [TestMethod]
        public void MinWindowTest6()
        {
            Assert.AreEqual("ksfor", ArraysAndStrings.MinWindow("geeksforgeeks", "ork"));
        }

        [TestMethod]
        public void MinWindowTest7()
        {
            Assert.AreEqual("BANC", ArraysAndStrings.MinWindow("ADOBECODEBANC", "ABC"));
        }

        [TestMethod]
        public void SpellcheckerTest1()
        {
            string[] wordlist = {"KiTe", "kite", "hare", "Hare"};
            string[] queries =  {"kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"};
            string[] expected = {"kite", "KiTe", "KiTe", "Hare", "hare",  "",     "",    "KiTe", "",     "KiTe"};
            CollectionAssert.AreEqual(expected, ArraysAndStrings.Spellchecker(wordlist, queries));
        }

        [TestMethod]
        public void IsToeplitzMatrixTest1()
        {
            int[,] mat = new int[,] { { 1 } };
            Assert.AreEqual(true, ArraysAndStrings.IsToeplitzMatrix(mat));
        }

        public void IsToeplitzMatrixTest2()
        {
            int[,] mat = new int[,] { { 1, 2 } };
            Assert.AreEqual(true, ArraysAndStrings.IsToeplitzMatrix(mat));
        }

        [TestMethod]
        public void IsToeplitzMatrixTest3()
        {
            int[,] mat = new int[,] { { 1, 2 }, { 3, 1 } };
            Assert.AreEqual(true, ArraysAndStrings.IsToeplitzMatrix(mat));
        }

        [TestMethod]
        public void IsToeplitzMatrixTest4()
        {
            int[,] mat = new int[,] { { 1, 1 }, { 1, 2 } };
            Assert.AreEqual(false, ArraysAndStrings.IsToeplitzMatrix(mat));
        }

        [TestMethod]
        public void IsToeplitzMatrixTest5()
        {
            int[,] mat = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 6, 5, 1, 2 } };
            Assert.AreEqual(true, ArraysAndStrings.IsToeplitzMatrix(mat));
        }

    }
}
